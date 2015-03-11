print "Введите строку: "
input = gets.to_s
chars = Array.new(input.length - 1){ |i| input[i]} #массив символов содержащихся в строке
chars = chars.uniq.collect{ |ch| [ch, chars.find_all { |key| key == ch }.size]} #Удаляем повторяющиеся,хешируем ключ-символ, значение - кол-во повторов
puts "[Символ, число повторений в строке]:"
p chars