
class BinarySearchTree{
    public static Node Insert(Node root, int value){
        if(root == null){
          root = new Node();
          root.Data = value;  
          return root;
        }else
        {
           if(value < root.Data){
            // insert left
            root.Left = Insert(root.Left,value); 

           }
           else if(value > root.Data){
            //insert to the right
             root.Right = Insert(root.Right,value); 
           } 
        }
        return root;
    }
}