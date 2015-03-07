print "Введите слово: "
word = gets

arr = Array.new(word.length - 1){ |i| word[i]}							#массив из символов слова

arr = arr.uniq.map{ |ch| [ch, word.scan(ch).size]}	#создание хеша, где ключ - символ, значение - их количество в слове

puts "[буква, число повторений в слове]:"
p arr
