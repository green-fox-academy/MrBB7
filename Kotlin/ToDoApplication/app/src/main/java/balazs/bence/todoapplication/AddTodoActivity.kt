package balazs.bence.todoapplication

import android.support.v7.app.AppCompatActivity
import android.os.Bundle

class AddTodoActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_add_todo)

        title = "New todo"
    }
}
