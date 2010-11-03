namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Collections : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Collections(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.Object min(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m0.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m0 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "min", "(Ljava/util/Collection;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.Object min(java.util.Collection arg0, java.util.Comparator arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m1.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "min", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.Object max(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m2.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m2 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "max", "(Ljava/util/Collection;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.lang.Object max(java.util.Collection arg0, java.util.Comparator arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m3.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m3 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "max", "(Ljava/util/Collection;Ljava/util/Comparator;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool replaceAll(java.util.List arg0, java.lang.Object arg1, java.lang.Object arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m4.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m4 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "replaceAll", "(Ljava/util/List;Ljava/lang/Object;Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static bool addAll(java.util.Collection arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m5.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "addAll", "(Ljava/util/Collection;[Ljava/lang/Object;)Z");
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.util.ArrayList list(java.util.Enumeration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m6.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "list", "(Ljava/util/Enumeration;)Ljava/util/ArrayList;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.util.Set synchronizedSet(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m7.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m7 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSet", "(Ljava/util/Set;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.util.Collection synchronizedCollection(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m8.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedCollection", "(Ljava/util/Collection;)Ljava/util/Collection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static void copy(java.util.List arg0, java.util.List arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m9.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "copy", "(Ljava/util/List;Ljava/util/List;)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.util.List synchronizedList(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m10.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m10 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedList", "(Ljava/util/List;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static void reverse(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m11.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m11 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverse", "(Ljava/util/List;)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void fill(java.util.List arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m12.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m12 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "fill", "(Ljava/util/List;Ljava/lang/Object;)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static void sort(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m13.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m13 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "sort", "(Ljava/util/List;)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public static void sort(java.util.List arg0, java.util.Comparator arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m14.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m14 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "sort", "(Ljava/util/List;Ljava/util/Comparator;)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static void swap(java.util.List arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m15.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m15 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "swap", "(Ljava/util/List;II)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static int binarySearch(java.util.List arg0, java.lang.Object arg1, java.util.Comparator arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m16.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m16 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "binarySearch", "(Ljava/util/List;Ljava/lang/Object;Ljava/util/Comparator;)I");
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static int binarySearch(java.util.List arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m17.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m17 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "binarySearch", "(Ljava/util/List;Ljava/lang/Object;)I");
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static global::java.util.Map synchronizedMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m18.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m18 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedMap", "(Ljava/util/Map;)Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static void shuffle(java.util.List arg0, java.util.Random arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m19.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m19 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "shuffle", "(Ljava/util/List;Ljava/util/Random;)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public static void shuffle(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m20.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m20 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "shuffle", "(Ljava/util/List;)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public static void rotate(java.util.List arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m21.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m21 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "rotate", "(Ljava/util/List;I)V");
			@__env.CallStaticVoidMethod(java.util.Collections.staticClass, global::java.util.Collections._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public static int indexOfSubList(java.util.List arg0, java.util.List arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m22.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m22 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "indexOfSubList", "(Ljava/util/List;Ljava/util/List;)I");
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public static int lastIndexOfSubList(java.util.List arg0, java.util.List arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m23.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m23 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "lastIndexOfSubList", "(Ljava/util/List;Ljava/util/List;)I");
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public static global::java.util.Collection unmodifiableCollection(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m24.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m24 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableCollection", "(Ljava/util/Collection;)Ljava/util/Collection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static global::java.util.Set unmodifiableSet(java.util.Set arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m25.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m25 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSet", "(Ljava/util/Set;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public static global::java.util.SortedSet unmodifiableSortedSet(java.util.SortedSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m26.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m26 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public static global::java.util.List unmodifiableList(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m27.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m27 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableList", "(Ljava/util/List;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public static global::java.util.Map unmodifiableMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m28.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m28 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableMap", "(Ljava/util/Map;)Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public static global::java.util.SortedMap unmodifiableSortedMap(java.util.SortedMap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m29.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m29 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "unmodifiableSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public static global::java.util.SortedSet synchronizedSortedSet(java.util.SortedSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m30.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m30 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSortedSet", "(Ljava/util/SortedSet;)Ljava/util/SortedSet;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public static global::java.util.SortedMap synchronizedSortedMap(java.util.SortedMap arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m31.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m31 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "synchronizedSortedMap", "(Ljava/util/SortedMap;)Ljava/util/SortedMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static global::java.util.Collection checkedCollection(java.util.Collection arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m32.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m32 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedCollection", "(Ljava/util/Collection;Ljava/lang/Class;)Ljava/util/Collection;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public static global::java.util.Set checkedSet(java.util.Set arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m33.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m33 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSet", "(Ljava/util/Set;Ljava/lang/Class;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public static global::java.util.SortedSet checkedSortedSet(java.util.SortedSet arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m34.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m34 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSortedSet", "(Ljava/util/SortedSet;Ljava/lang/Class;)Ljava/util/SortedSet;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedSet>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.SortedSet;
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public static global::java.util.List checkedList(java.util.List arg0, java.lang.Class arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m35.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m35 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedList", "(Ljava/util/List;Ljava/lang/Class;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public static global::java.util.Map checkedMap(java.util.Map arg0, java.lang.Class arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m36.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m36 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedMap", "(Ljava/util/Map;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public static global::java.util.SortedMap checkedSortedMap(java.util.SortedMap arg0, java.lang.Class arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m37.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m37 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "checkedSortedMap", "(Ljava/util/SortedMap;Ljava/lang/Class;Ljava/lang/Class;)Ljava/util/SortedMap;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.SortedMap>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.SortedMap;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public static global::java.util.Set emptySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m38.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m38 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptySet", "()Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m38)) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static global::java.util.List emptyList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m39.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m39 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptyList", "()Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m39)) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public static global::java.util.Map emptyMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m40.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m40 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "emptyMap", "()Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m40)) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public static global::java.util.Set singleton(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m41.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m41 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singleton", "(Ljava/lang/Object;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public static global::java.util.List singletonList(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m42.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m42 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singletonList", "(Ljava/lang/Object;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public static global::java.util.Map singletonMap(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m43.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m43 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "singletonMap", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public static global::java.util.List nCopies(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m44.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m44 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "nCopies", "(ILjava/lang/Object;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public static global::java.util.Comparator reverseOrder(java.util.Comparator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m45.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m45 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverseOrder", "(Ljava/util/Comparator;)Ljava/util/Comparator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Comparator;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public static global::java.util.Comparator reverseOrder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m46.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m46 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "reverseOrder", "()Ljava/util/Comparator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Comparator>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m46)) as java.util.Comparator;
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public static global::java.util.Enumeration enumeration(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m47.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m47 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "enumeration", "(Ljava/util/Collection;)Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public static int frequency(java.util.Collection arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m48.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m48 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "frequency", "(Ljava/util/Collection;Ljava/lang/Object;)I");
			return @__env.CallStaticIntMethod(java.util.Collections.staticClass, global::java.util.Collections._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public static bool disjoint(java.util.Collection arg0, java.util.Collection arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m49.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m49 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "disjoint", "(Ljava/util/Collection;Ljava/util/Collection;)Z");
			return @__env.CallStaticBooleanMethod(java.util.Collections.staticClass, global::java.util.Collections._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public static global::java.util.Set newSetFromMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.Collections._m50.native == global::System.IntPtr.Zero)
				global::java.util.Collections._m50 = @__env.GetStaticMethodIDNoThrow(global::java.util.Collections.staticClass, "newSetFromMap", "(Ljava/util/Map;)Ljava/util/Set;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallStaticObjectMethod(java.util.Collections.staticClass, global::java.util.Collections._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Set;
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_SET6793;
		public static global::java.util.Set EMPTY_SET
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_SET6793)) as java.util.Set;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_LIST6794;
		public static global::java.util.List EMPTY_LIST
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_LIST6794)) as java.util.List;
			}
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY_MAP6795;
		public static global::java.util.Map EMPTY_MAP
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.GetStaticObjectField(global::java.util.Collections.staticClass, _EMPTY_MAP6795)) as java.util.Map;
			}
		}
		static Collections()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Collections.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Collections"));
			global::java.util.Collections._EMPTY_SET6793 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_SET", "Ljava/util/Set;");
			global::java.util.Collections._EMPTY_LIST6794 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_LIST", "Ljava/util/List;");
			global::java.util.Collections._EMPTY_MAP6795 = @__env.GetStaticFieldIDNoThrow(global::java.util.Collections.staticClass, "EMPTY_MAP", "Ljava/util/Map;");
		}
	}
}
