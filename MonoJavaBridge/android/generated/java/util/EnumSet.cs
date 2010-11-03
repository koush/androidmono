namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.EnumSet_))]
	public abstract partial class EnumSet : java.util.AbstractSet, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EnumSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.util.EnumSet clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumSet.staticClass, "clone", "()Ljava/util/EnumSet;", ref global::java.util.EnumSet._m0) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.util.EnumSet copyOf(java.util.EnumSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m1.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m1 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "copyOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.util.EnumSet copyOf(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m2.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m2 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "copyOf", "(Ljava/util/Collection;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::java.util.EnumSet range(java.lang.Enum arg0, java.lang.Enum arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m3.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m3 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "range", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2, java.lang.Enum arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m4.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m4 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::java.util.EnumSet of(java.lang.Enum arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m5.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m5 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m6.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m6 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m7.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m7 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2, java.lang.Enum arg3, java.lang.Enum arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m8.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m8 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m9.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m9 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::java.util.EnumSet noneOf(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m10.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m10 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "noneOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static global::java.util.EnumSet allOf(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m11.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m11 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "allOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static global::java.util.EnumSet complementOf(java.util.EnumSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._m12.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._m12 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "complementOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		static EnumSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumSet"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.EnumSet))]
	internal sealed partial class EnumSet_ : java.util.EnumSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EnumSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.EnumSet_.staticClass, "size", "()I", ref global::java.util.EnumSet_._m0);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.EnumSet_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.EnumSet_._m1) as java.util.Iterator;
		}
		static EnumSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumSet"));
		}
	}
}
