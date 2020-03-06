package com.reddy98.vishnuvardhan.digitalregister;

import android.content.Intent;
import android.net.Uri;
import android.provider.MediaStore;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Gallery;
import android.widget.ImageView;

public class FourthActivity extends AppCompatActivity {


    Button TP;
    Button OG;
    ImageView IV;
    Uri imageUri;
    static final int OpenGallery=1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fourth);

        TP=findViewById(R.id.tp);
        OG=findViewById(R.id.og);
        IV=findViewById(R.id.iv);

        TP.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent=new Intent(FourthActivity.this,SecondActivity.class);
                startActivity(intent);
            }
        });

        OG.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                open_gallery();
            }
        });

    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data)
    {
        if(resultCode==RESULT_OK && requestCode==OpenGallery)
        {
            imageUri=data.getData();
            IV.setImageURI(imageUri);
        }
    }


    public void open_gallery()
    {
        Intent gallery=new Intent(Intent.ACTION_PICK, MediaStore.Images.Media.INTERNAL_CONTENT_URI);
        startActivityForResult(gallery,OpenGallery);
    }
}
