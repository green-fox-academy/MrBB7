package balazs.bence.themoviedatabaseapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Button getMovieByIDButton = (Button)findViewById(R.id.searchMovieByIdButton);
        getMovieByIDButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent searchIntent = new Intent(MainActivity.this, SearchMovieByID.class);
                startActivity(searchIntent);
            }
        });
    }

    @Override
    public void onClick(View view) {

    }
}
