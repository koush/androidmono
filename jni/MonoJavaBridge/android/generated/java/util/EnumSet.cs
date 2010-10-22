namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.EnumSet_))]
	public abstract partial class EnumSet : java.util.AbstractSet, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EnumSet()
		{
			InitJNI();
		}
		protected EnumSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone26037;
		public virtual global::java.util.EnumSet clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumSet._clone26037)) as java.util.EnumSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumSet.staticClass, global::java.util.EnumSet._clone26037)) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _copyOf26038;
		public static global::java.util.EnumSet copyOf(java.util.EnumSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._copyOf26038, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _copyOf26039;
		public static global::java.util.EnumSet copyOf(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._copyOf26039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _range26040;
		public static global::java.util.EnumSet range(java.lang.Enum arg0, java.lang.Enum arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._range26040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26041;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2, java.lang.Enum arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26042;
		public static global::java.util.EnumSet of(java.lang.Enum arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26043;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26044;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26045;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2, java.lang.Enum arg3, java.lang.Enum arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of26046;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of26046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _noneOf26047;
		public static global::java.util.EnumSet noneOf(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._noneOf26047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _allOf26048;
		public static global::java.util.EnumSet allOf(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._allOf26048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _complementOf26049;
		public static global::java.util.EnumSet complementOf(java.util.EnumSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._complementOf26049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumSet"));
			global::java.util.EnumSet._clone26037 = @__env.GetMethodIDNoThrow(global::java.util.EnumSet.staticClass, "clone", "()Ljava/util/EnumSet;");
			global::java.util.EnumSet._copyOf26038 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "copyOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._copyOf26039 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "copyOf", "(Ljava/util/Collection;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._range26040 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "range", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of26041 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of26042 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of26043 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of26044 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of26045 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of26046 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._noneOf26047 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "noneOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._allOf26048 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "allOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._complementOf26049 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "complementOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.EnumSet))]
	public sealed partial class EnumSet_ : java.util.EnumSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EnumSet_()
		{
			InitJNI();
		}
		internal EnumSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size26050;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.EnumSet_._size26050);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.EnumSet_.staticClass, global::java.util.EnumSet_._size26050);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26051;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumSet_._iterator26051)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumSet_.staticClass, global::java.util.EnumSet_._iterator26051)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumSet"));
			global::java.util.EnumSet_._size26050 = @__env.GetMethodIDNoThrow(global::java.util.EnumSet_.staticClass, "size", "()I");
			global::java.util.EnumSet_._iterator26051 = @__env.GetMethodIDNoThrow(global::java.util.EnumSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
