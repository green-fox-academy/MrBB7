package com.example.demo.services;

import com.example.demo.model.Post;
import com.example.demo.repositories.PostRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class PostServiceImpl implements PostService{

    @Autowired
    private PostRepository postRepository;

    @Override
    public void addPost(Post post) {
        postRepository.save(post);
    }

    @Override
    public List<Post> getAllPost() {
        List<Post> posts = new ArrayList<>();
        postRepository.findAll().forEach(posts::add);
        return posts;
    }

    @Override
    public void upVote(Integer id) {
        Post current = postRepository.findById(id).get();
        current.setVote(current.getVote() + 1);
        postRepository.save(current);
    }

    @Override
    public void downVote(Integer id) {
        Post current = postRepository.findById(id).get();
        current.setVote(current.getVote() + 1);
        postRepository.save(current);
    }
}
