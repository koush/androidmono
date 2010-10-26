namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.Dictionary_))]
	public abstract partial class Dictionary : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Dictionary()
		{
			InitJNI();
		}
		protected Dictionary(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26120;
		public abstract global::java.lang.Object get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _put26121;
		public abstract global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _isEmpty26122;
		public abstract bool isEmpty();
		internal static global::MonoJavaBridge.MethodId _size26123;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _remove26124;
		public abstract global::java.lang.Object remove(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _elements26125;
		public abstract global::java.util.Enumeration elements();
		internal static global::MonoJavaBridge.MethodId _keys26126;
		public abstract global::java.util.Enumeration keys();
		internal static global::MonoJavaBridge.MethodId _Dictionary26127;
		public Dictionary()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Dictionary.staticClass, global::java.util.Dictionary._Dictionary26127);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
			global::java.util.Dictionary._get26120 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._put26121 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._isEmpty26122 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "isEmpty", "()Z");
			global::java.util.Dictionary._size26123 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "size", "()I");
			global::java.util.Dictionary._remove26124 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._elements26125 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary._keys26126 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary._Dictionary26127 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Dictionary))]
	internal sealed partial class Dictionary_ : java.util.Dictionary
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Dictionary_()
		{
			InitJNI();
		}
		internal Dictionary_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26128;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._get26128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._get26128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26129;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._put26129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._put26129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26130;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Dictionary_._isEmpty26130);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._isEmpty26130);
		}
		internal static global::MonoJavaBridge.MethodId _size26131;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Dictionary_._size26131);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._size26131);
		}
		internal static global::MonoJavaBridge.MethodId _remove26132;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._remove26132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._remove26132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements26133;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._elements26133)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._elements26133)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys26134;
		public override global::java.util.Enumeration keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._keys26134)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._keys26134)) as java.util.Enumeration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
			global::java.util.Dictionary_._get26128 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._put26129 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._isEmpty26130 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "isEmpty", "()Z");
			global::java.util.Dictionary_._size26131 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "size", "()I");
			global::java.util.Dictionary_._remove26132 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._elements26133 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary_._keys26134 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "keys", "()Ljava/util/Enumeration;");
		}
	}
}
