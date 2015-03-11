puts "Задайте длину массива n:"
n = gets.chomp.to_i
arr = Array.new(n.to_i){ rand(10) }
print "Исходный массив: "
p arr
mean = (1...(n.to_i - 1)).to_a.map{ |i| ((arr[i - 1] + arr[i] + arr[i + 1])/3.0).round(2) }
mean.unshift(((arr[0] + arr[1])/2.0).round(2))
mean.push(((arr[-1] + arr[-2])/2.0).round(2))
print "Массив средних арифметических: "
p mean