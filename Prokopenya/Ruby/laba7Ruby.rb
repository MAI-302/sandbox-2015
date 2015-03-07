puts "Введите число строк матрицы "
n = gets.to_i

puts "Введите число столбцов матрицы "
m = gets.to_i

arr = []

(0...n).each do |i|
	arr[i] = Array.new(n.to_i){rand(10)}
end

0.upto(arr.size - 1) { |i| p arr[i] }

print "Минимальный из максимальных элементов строк: "
puts arr.map{ |a| a.max }.min