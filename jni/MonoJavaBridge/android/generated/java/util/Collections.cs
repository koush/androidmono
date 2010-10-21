namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Collections : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Collections()
		{
			InitJNI();
		}
		protected Collections(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _min25903;
		public static global::java.lang.Object min(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._min25903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _min25904;
		public static global::java.lang.Object min(java.util.Collection arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._min25904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _max25905;
		public static global::java.lang.Object max(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._max25905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _max25906;
		public static global::java.lang.Object max(java.util.Collection arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._max25906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _replaceAll25907;
		public static bool replaceAll(java.util.List arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._replaceAll25907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addAll25908;
		public static bool addAll(java.util.Collection arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._addAll25908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _list25909;
		public static global::java.util.ArrayList list(java.util.Enumeration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._list25909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSet25910;
		public static global::java.util.Set synchronizedSet(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSet25910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedCollection25911;
		public static global::java.util.Collection synchronizedCollection(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedCollection25911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _copy25912;
		public static void copy(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._copy25912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedList25913;
		public static global::java.util.List synchronizedList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedList25913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _reverse25914;
		public static void reverse(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._reverse25914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _fill25915;
		public static void fill(java.util.List arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._fill25915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _sort25916;
		public static void sort(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._sort25916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _sort25917;
		public static void sort(java.util.List arg0, java.util.Comparator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._sort25917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _swap25918;
		public static void swap(java.util.List arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._swap25918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25919;
		public static int binarySearch(java.util.List arg0, java.lang.Object arg1, java.util.Comparator arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._binarySearch25919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _binarySearch25920;
		public static int binarySearch(java.util.List arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._binarySearch25920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedMap25921;
		public static global::java.util.Map synchronizedMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedMap25921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _shuffle25922;
		public static void shuffle(java.util.List arg0, java.util.Random arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._shuffle25922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shuffle25923;
		public static void shuffle(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._shuffle25923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _rotate25924;
		public static void rotate(java.util.List arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._rotate25924, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _indexOfSubList25925;
		public static int indexOfSubList(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._indexOfSubList25925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOfSubList25926;
		public static int lastIndexOfSubList(java.util.List arg0, java.util.List arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._lastIndexOfSubList25926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableCollection25927;
		public static global::java.util.Collection unmodifiableCollection(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableCollection25927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSet25928;
		public static global::java.util.Set unmodifiableSet(java.util.Set arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSet25928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSortedSet25929;
		public static global::java.util.SortedSet unmodifiableSortedSet(java.util.SortedSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSortedSet25929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableList25930;
		public static global::java.util.List unmodifiableList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableList25930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableMap25931;
		public static global::java.util.Map unmodifiableMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableMap25931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _unmodifiableSortedMap25932;
		public static global::java.util.SortedMap unmodifiableSortedMap(java.util.SortedMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._unmodifiableSortedMap25932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSortedSet25933;
		public static global::java.util.SortedSet synchronizedSortedSet(java.util.SortedSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSortedSet25933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _synchronizedSortedMap25934;
		public static global::java.util.SortedMap synchronizedSortedMap(java.util.SortedMap arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._synchronizedSortedMap25934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _checkedCollection25935;
		public static global::java.util.Collection checkedCollection(java.util.Collection arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedCollection25935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSet25936;
		public static global::java.util.Set checkedSet(java.util.Set arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSet25936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSortedSet25937;
		public static global::java.util.SortedSet checkedSortedSet(java.util.SortedSet arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSortedSet25937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		internal static global::MonoJavaBridge.MethodId _checkedList25938;
		public static global::java.util.List checkedList(java.util.List arg0, java.lang.Class arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedList25938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _checkedMap25939;
		public static global::java.util.Map checkedMap(java.util.Map arg0, java.lang.Class arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedMap25939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _checkedSortedMap25940;
		public static global::java.util.SortedMap checkedSortedMap(java.util.SortedMap arg0, java.lang.Class arg1, java.lang.Class arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._checkedSortedMap25940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.SortedMap;
		}
		internal static global::MonoJavaBridge.MethodId _emptySet25941;
		public static global::java.util.Set emptySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptySet25941)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _emptyList25942;
		public static global::java.util.List emptyList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptyList25942)) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _emptyMap25943;
		public static global::java.util.Map emptyMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._emptyMap25943)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _singleton25944;
		public static global::java.util.Set singleton(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singleton25944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _singletonList25945;
		public static global::java.util.List singletonList(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singletonList25945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _singletonMap25946;
		public static global::java.util.Map singletonMap(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._singletonMap25946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _nCopies25947;
		public static global::java.util.List nCopies(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._nCopies25947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _reverseOrder25948;
		public static global::java.util.Comparator reverseOrder(java.util.Comparator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._reverseOrder25948, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _reverseOrder25949;
		public static global::java.util.Comparator reverseOrder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._reverseOrder25949)) as java.util.Comparator;
		}
		internal static global::MonoJavaBridge.MethodId _enumeration25950;
		public static global::java.util.Enumeration enumeration(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._enumeration25950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _frequency25951;
		public static int frequency(java.util.Collection arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._frequency25951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _disjoint25952;
		public static bool disjoint(java.util.Collection arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._disjoint25952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _newSetFromMap25953;
		public static global::java.util.Set newSetFromMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._newSetFromMap25953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_SET25954;
		public static global::java.util.Set EMPTY_SET
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_SET25954)) as java.util.Set;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_LIST25955;
		public static global::java.util.List EMPTY_LIST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_LIST25955)) as java.util.List;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_MAP25956;
		public static global::java.util.Map EMPTY_MAP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_MAP25956)) as java.util.Map;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Collections.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Collections"));
			global::java.util.Collections._min25903 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "min", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.Collections._min25904 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "min", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;");
			global::java.util.Collections._max25905 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "max", "(Ljava/util/Collection;)Ljava/lang/Object;");
			global::java.util.Collections._max25906 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "max", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;");
			global::java.util.Collections._replaceAll25907 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "replaceAll", "(Ljava/util/List;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.Collections._addAll25908 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "addAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z");
			global::java.util.Collections._list25909 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "list", "(Ljava/util/Enumeration;)Ljava/util/ArrayList;");
			global::java.util.Collections._synchronizedSet25910 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSet", "(Ljava/util/Set;)Ljava/util/Set;");
			global::java.util.Collections._synchronizedCollection25911 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedCollection", "(Ljava/util/Collection;)Ljava/util/Collection;");
			global::java.util.Collections._copy25912 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "copy", "(Ljava/util/List;Ljava/util/List;)V");
			global::java.util.Collections._synchronizedList25913 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedList", "(Ljava/util/List;)Ljava/util/List;");
			global::java.util.Collections._reverse25914 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverse", "(Ljava/util/List;)V");
			global::java.util.Collections._fill25915 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "fill", "(Ljava/util/List;Ljava/lang/Object;)V");
			global::java.util.Collections._sort25916 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "sort", "(Ljava/util/List;)V");
			global::java.util.Collections._sort25917 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "sort", "(Ljava/util/List;Ljava/util/Comparator;)V");
			global::java.util.Collections._swap25918 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "swap", "(Ljava/util/List;II)V");
			global::java.util.Collections._binarySearch25919 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "binarySearch", "(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;)I");
			global::java.util.Collections._binarySearch25920 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "binarySearch", "(Ljava/util/List;Ljava/lang/Object;)I");
			global::java.util.Collections._synchronizedMap25921 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedMap", "(Ljava/util/Map;)Ljava/util/Map;");
			global::java.util.Collections._shuffle25922 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "shuffle", "(Ljava/util/List;Ljava/util/Random;)V");
			global::java.util.Collections._shuffle25923 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "shuffle", "(Ljava/util/List;)V");
			global::java.util.Collections._rotate25924 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "rotate", "(Ljava/util/List;I)V");
			global::java.util.Collections._indexOfSubList25925 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "indexOfSubList", "(Ljava/util/List;Ljava/util/List;)I");
			global::java.util.Collections._lastIndexOfSubList25926 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "lastIndexOfSubList", "(Ljava/util/List;Ljava/util/List;)I");
			global::java.util.Collections._unmodifiableCollection25927 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableCollection", "(Ljava/util/Collection;)Ljava/util/Collection;");
			global::java.util.Collections._unmodifiableSet25928 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSet", "(Ljava/util/Set;)Ljava/util/Set;");
			global::java.util.Collections._unmodifiableSortedSet25929 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			global::java.util.Collections._unmodifiableList25930 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableList", "(Ljava/util/List;)Ljava/util/List;");
			global::java.util.Collections._unmodifiableMap25931 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableMap", "(Ljava/util/Map;)Ljava/util/Map;");
			global::java.util.Collections._unmodifiableSortedMap25932 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;");
			global::java.util.Collections._synchronizedSortedSet25933 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			global::java.util.Collections._synchronizedSortedMap25934 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;");
			global::java.util.Collections._checkedCollection25935 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedCollection", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;");
			global::java.util.Collections._checkedSet25936 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSet", "(Ljava/util/Set;Ljava/lang/Class;)Ljava/util/Set;");
			global::java.util.Collections._checkedSortedSet25937 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSortedSet", "(Ljava/util/SortedSet;Ljava/lang/Class;)Ljava/util/SortedSet;");
			global::java.util.Collections._checkedList25938 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedList", "(Ljava/util/List;Ljava/lang/Class;)Ljava/util/List;");
			global::java.util.Collections._checkedMap25939 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedMap", "(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/Map;");
			global::java.util.Collections._checkedSortedMap25940 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSortedMap", "(Ljava/util/SortedMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/SortedMap;");
			global::java.util.Collections._emptySet25941 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptySet", "()Ljava/util/Set;");
			global::java.util.Collections._emptyList25942 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptyList", "()Ljava/util/List;");
			global::java.util.Collections._emptyMap25943 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptyMap", "()Ljava/util/Map;");
			global::java.util.Collections._singleton25944 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singleton", "(Ljava/lang/Object;)Ljava/util/Set;");
			global::java.util.Collections._singletonList25945 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singletonList", "(Ljava/lang/Object;)Ljava/util/List;");
			global::java.util.Collections._singletonMap25946 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singletonMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;");
			global::java.util.Collections._nCopies25947 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "nCopies", "(ILjava/lang/Object;)Ljava/util/List;");
			global::java.util.Collections._reverseOrder25948 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverseOrder", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
			global::java.util.Collections._reverseOrder25949 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverseOrder", "()Ljava/util/Comparator;");
			global::java.util.Collections._enumeration25950 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "enumeration", "(Ljava/util/Collection;)Ljava/util/Enumeration;");
			global::java.util.Collections._frequency25951 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "frequency", "(Ljava/util/Collection;Ljava/lang/Object;)I");
			global::java.util.Collections._disjoint25952 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "disjoint", "(Ljava/util/Collection;Ljava/util/Collection;)Z");
			global::java.util.Collections._newSetFromMap25953 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "newSetFromMap", "(Ljava/util/Map;)Ljava/util/Set;");
			global::java.util.Collections._EMPTY_SET25954 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_SET", "Ljava/util/Set;");
			global::java.util.Collections._EMPTY_LIST25955 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_LIST", "Ljava/util/List;");
			global::java.util.Collections._EMPTY_MAP25956 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_MAP", "Ljava/util/Map;");
		}
	}
}
