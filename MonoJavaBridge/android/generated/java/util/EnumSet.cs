namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.EnumSet_))]
	public abstract partial class EnumSet : java.util.AbstractSet, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EnumSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone26156;
		public virtual global::java.util.EnumSet clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.EnumSet.staticClass, "clone", "()Ljava/util/EnumSet;", ref global::java.util.EnumSet._clone26156) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _copyOf26157;
		public static global::java.util.EnumSet copyOf(java.util.EnumSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._copyOf26157.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._copyOf26157 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "copyOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._copyOf26157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _copyOf26158;
		public static global::java.util.EnumSet copyOf(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._copyOf26158.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._copyOf26158 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "copyOf", "(Ljava/util/Collection;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._copyOf26158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _range26159;
		public static global::java.util.EnumSet range(java.lang.Enum arg0, java.lang.Enum arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._range26159.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._range26159 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "range", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._range26159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26160;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2, java.lang.Enum arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._of26160.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._of26160 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26161;
		public static global::java.util.EnumSet of(java.lang.Enum arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._of26161.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._of26161 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26162;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._of26162.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._of26162 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26163;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._of26163.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._of26163 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26164;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2, java.lang.Enum arg3, java.lang.Enum arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._of26164.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._of26164 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26165;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._of26165.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._of26165 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _noneOf26166;
		public static global::java.util.EnumSet noneOf(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._noneOf26166.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._noneOf26166 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "noneOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._noneOf26166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _allOf26167;
		public static global::java.util.EnumSet allOf(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._allOf26167.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._allOf26167 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "allOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._allOf26167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _complementOf26168;
		public static global::java.util.EnumSet complementOf(java.util.EnumSet arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.EnumSet._complementOf26168.native == global::System.IntPtr.Zero)
				global::java.util.EnumSet._complementOf26168 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "complementOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._complementOf26168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		static EnumSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumSet"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.EnumSet))]
	internal sealed partial class EnumSet_ : java.util.EnumSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal EnumSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size26169;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.EnumSet_.staticClass, "size", "()I", ref global::java.util.EnumSet_._size26169);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26170;
		public override global::java.util.Iterator iterator()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::java.util.EnumSet_.staticClass, "iterator", "()Ljava/util/Iterator;", ref global::java.util.EnumSet_._iterator26170) as java.util.Iterator;
		}
		static EnumSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumSet"));
		}
		internal static void InitJNI()
		{
		}
	}
}
