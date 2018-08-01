package com.example.demo.controllers;

import com.example.demo.model.Post;
import com.example.demo.services.PostService;
import com.example.demo.services.PostServiceImpl;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.ResponseBody;

import java.util.List;

@Controller
public class PostController {

    PostService service;

    @Autowired
    public PostController(PostServiceImpl service) {
        this.service = service;
    }

    @GetMapping("")
    public String mainPage(Model model){
        model.addAttribute("posts", service.getAllPost());
        return "index";
    }

    @GetMapping("/newpost")
    public String addPostPage(Model model){
        model.addAttribute("post", new Post());
        return "add";
    }

    @PostMapping("/newpost")
    public String addPostPage(@ModelAttribute Post post){
        service.addPost(post);
        return "redirect:/";
    }

    @PostMapping("/upvote")
    public String upVote(@ModelAttribute(value = "id") Integer id){
        service.upVote(id);
        return "index";
    }

    @PostMapping("/downvote")
    public String downVote(@ModelAttribute(value = "id") Integer id){
        service.downVote(id);
        return "redirect:/";
    }

    @GetMapping("/rest")
    @ResponseBody
    public List<Post> jsonOut(){
        return service.getAllPost();
    }
}
