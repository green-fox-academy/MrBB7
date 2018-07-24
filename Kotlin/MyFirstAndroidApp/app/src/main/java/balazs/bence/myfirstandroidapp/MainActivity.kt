package balazs.bence.myfirstandroidapp

import android.content.Intent
import android.net.Uri
import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import java.net.URL

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        var workHistory = findViewById<Button>(R.id.workHistoryButton)

        workHistory.setOnClickListener {
            println("Hit the button!")

            var moveToWorkHistory = Intent(getApplicationContext(), WorkHistoryActivity::class.java)

            startActivity(moveToWorkHistory)
        }

        var callButton = findViewById<Button>(R.id.callButton)

        callButton.setOnClickListener {
            println("Call")

            var phoneUri = Uri.parse("tel:2341231213")
            var callIntent = Intent(Intent.ACTION_DIAL,phoneUri )
            startActivity(callIntent)
        }

        var emailButton = findViewById<Button>(R.id.emailButton)

        emailButton.setOnClickListener {
            println("Email")

            var emailIntent = Intent(Intent.ACTION_SEND)
            emailIntent.setType("plain/text")
            emailIntent.putExtra(Intent.EXTRA_EMAIL, "johndoe@gmail.com")
            emailIntent.putExtra(Intent.EXTRA_SUBJECT, "lovely CV")
            emailIntent.putExtra(Intent.EXTRA_TEXT, "I was amazed by your CV...")
            startActivity(emailIntent)
        }
    }
}
