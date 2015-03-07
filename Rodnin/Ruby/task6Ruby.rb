puts "Задайте длину массива n:"
n = gets.chomp.to_i
mas = []
mean = []
puts "Исходный массив: "
(0...n).each do |i|
	mas[i] = rand(100)-rand(100)
	print mas[i]
	puts ""
end
mean[0] = (mas[0] + mas[1]) / 2.0;
mean[n - 1] = (mas[n - 1] + mas[n - 2]) / 2.0;
(1...n-1).each do |i|
	mean[i] = (mas[i] + mas[i - 1] + mas[i + 1]) / 3.0
end
(0...n).each do |i|
	print mean[i]
	puts ""
end
