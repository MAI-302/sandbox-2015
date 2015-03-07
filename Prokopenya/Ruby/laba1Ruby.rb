print "Введите слово: "

word = gets

count = (2...word.length).to_a.inject(1){ |result, i| result*i}

arr = Array.new(word.length - 1){ |i| word[i]}

arr = arr.uniq.map{ |ch| word.scan(ch).size }

0.upto(arr.size - 1) { |i| count = count / (1..arr[i].to_i).to_a.inject(1){ |result, i| result*i}}

print "Количество анаграмм: "

puts count