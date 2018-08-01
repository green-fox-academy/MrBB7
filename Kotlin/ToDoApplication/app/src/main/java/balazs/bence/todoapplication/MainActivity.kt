package balazs.bence.todoapplication

import android.content.Intent
import android.os.Bundle
import android.support.design.widget.Snackbar
import android.support.v7.app.AppCompatActivity
import android.view.Menu
import android.view.MenuItem
import io.realm.Realm

import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        setSupportActionBar(toolbar)

        fab.setOnClickListener {
            var addIntent = Intent(this, AddTodoActivity::class.java)
            startActivity(addIntent)
        }

        val realm = Realm.getDefaultInstance()

        var myDog = realm.createObject(Dog::class.java)
        myDog.name = "comehere"
        myDog.age = 1

        realm.beginTransaction()

        realm.copyToRealm(myDog)

        realm.commitTransaction()

        var query = realm.where(Dog::class.java)
        val results = query.findAll()
        for (dog in results) {
            println(dog.name)
        }
    }

    override fun onCreateOptionsMenu(menu: Menu): Boolean {
        // Inflate the menu; this adds items to the action bar if it is present.
        menuInflater.inflate(R.menu.menu_main, menu)
        return true
    }

    override fun onOptionsItemSelected(item: MenuItem): Boolean {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        return when (item.itemId) {
            R.id.action_settings -> true
            else -> super.onOptionsItemSelected(item)
        }
    }
}
