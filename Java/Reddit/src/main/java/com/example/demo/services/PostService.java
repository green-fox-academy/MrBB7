package com.example.demo.services;

import com.example.demo.model.Post;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public interface PostService {
    void addPost(Post post);
    List<Post> getAllPost();
    void upVote(Integer id);
    void downVote(Integer id);
}
