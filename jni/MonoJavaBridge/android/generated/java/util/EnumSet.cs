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
		internal static global::MonoJavaBridge.MethodId _clone20217;
		public virtual global::java.util.EnumSet clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumSet._clone20217)) as java.util.EnumSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumSet.staticClass, global::java.util.EnumSet._clone20217)) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _copyOf20218;
		public static global::java.util.EnumSet copyOf(java.util.EnumSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._copyOf20218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _copyOf20219;
		public static global::java.util.EnumSet copyOf(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._copyOf20219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _range20220;
		public static global::java.util.EnumSet range(java.lang.Enum arg0, java.lang.Enum arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._range20220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of20221;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2, java.lang.Enum arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of20221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of20222;
		public static global::java.util.EnumSet of(java.lang.Enum arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of20222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of20223;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of20223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of20224;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of20224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of20225;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum arg1, java.lang.Enum arg2, java.lang.Enum arg3, java.lang.Enum arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of20225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _of20226;
		public static global::java.util.EnumSet of(java.lang.Enum arg0, java.lang.Enum[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._of20226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _noneOf20227;
		public static global::java.util.EnumSet noneOf(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._noneOf20227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _allOf20228;
		public static global::java.util.EnumSet allOf(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._allOf20228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		internal static global::MonoJavaBridge.MethodId _complementOf20229;
		public static global::java.util.EnumSet complementOf(java.util.EnumSet arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.util.EnumSet.staticClass, global::java.util.EnumSet._complementOf20229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.EnumSet;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumSet"));
			global::java.util.EnumSet._clone20217 = @__env.GetMethodIDNoThrow(global::java.util.EnumSet.staticClass, "clone", "()Ljava/util/EnumSet;");
			global::java.util.EnumSet._copyOf20218 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "copyOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._copyOf20219 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "copyOf", "(Ljava/util/Collection;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._range20220 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "range", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of20221 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of20222 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of20223 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of20224 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of20225 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._of20226 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "of", "(Ljava/lang/Enum;[Ljava/lang/Enum;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._noneOf20227 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "noneOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._allOf20228 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "allOf", "(Ljava/lang/Class;)Ljava/util/EnumSet;");
			global::java.util.EnumSet._complementOf20229 = @__env.GetStaticMethodIDNoThrow(global::java.util.EnumSet.staticClass, "complementOf", "(Ljava/util/EnumSet;)Ljava/util/EnumSet;");
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
		internal static global::MonoJavaBridge.MethodId _size20230;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.EnumSet_._size20230);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.EnumSet_.staticClass, global::java.util.EnumSet_._size20230);
		}
		internal static global::MonoJavaBridge.MethodId _iterator20231;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.EnumSet_._iterator20231)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.EnumSet_.staticClass, global::java.util.EnumSet_._iterator20231)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.EnumSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/EnumSet"));
			global::java.util.EnumSet_._size20230 = @__env.GetMethodIDNoThrow(global::java.util.EnumSet_.staticClass, "size", "()I");
			global::java.util.EnumSet_._iterator20231 = @__env.GetMethodIDNoThrow(global::java.util.EnumSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
