print "Введите слово: "
text = gets.to_s

mas = Array.new(text.length - 1){ |i| text[i]}		

mas = mas.uniq.map{ |c| [c, text.scan(c).size]}	

puts "[символ, число повторений в тексте]:"
p mas