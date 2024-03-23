using System.Text.Json;

int SummarizeFunction(JsonDocument JDoc){
    int count = 0; //remember to change names
    int count2 = 0;
    int count3 = 0;
    foreach value in JDoc{
        count += value;
    }
    foreach innerarray in JDoc{
        count2++;
    }
    }   foreach node in nodes {
        count3 ++;
   }
}
class nodes{
    int value = this.value;
    var right = this.right;
    var left = this.left;
}