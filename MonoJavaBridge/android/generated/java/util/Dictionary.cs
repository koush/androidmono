namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.Dictionary_))]
	public abstract partial class Dictionary : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Dictionary(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26121;
		public abstract global::java.lang.Object get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _put26122;
		public abstract global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _isEmpty26123;
		public abstract bool isEmpty();
		internal static global::MonoJavaBridge.MethodId _size26124;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _remove26125;
		public abstract global::java.lang.Object remove(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _elements26126;
		public abstract global::java.util.Enumeration elements();
		internal static global::MonoJavaBridge.MethodId _keys26127;
		public abstract global::java.util.Enumeration keys();
		internal static global::MonoJavaBridge.MethodId _Dictionary26128;
		public Dictionary() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Dictionary.staticClass, global::java.util.Dictionary._Dictionary26128);
			Init(@__env, handle);
		}
		static Dictionary()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
			global::java.util.Dictionary._get26121 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._put26122 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._isEmpty26123 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "isEmpty", "()Z");
			global::java.util.Dictionary._size26124 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "size", "()I");
			global::java.util.Dictionary._remove26125 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._elements26126 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary._keys26127 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary._Dictionary26128 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Dictionary))]
	internal sealed partial class Dictionary_ : java.util.Dictionary
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Dictionary_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26129;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._get26129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26130;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._put26130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26131;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Dictionary_._isEmpty26131);
		}
		internal static global::MonoJavaBridge.MethodId _size26132;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallIntMethod(this.JvmHandle, global::java.util.Dictionary_._size26132);
		}
		internal static global::MonoJavaBridge.MethodId _remove26133;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._remove26133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements26134;
		public override global::java.util.Enumeration elements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._elements26134)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys26135;
		public override global::java.util.Enumeration keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._keys26135)) as java.util.Enumeration;
		}
		static Dictionary_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
			global::java.util.Dictionary_._get26129 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._put26130 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._isEmpty26131 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "isEmpty", "()Z");
			global::java.util.Dictionary_._size26132 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "size", "()I");
			global::java.util.Dictionary_._remove26133 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._elements26134 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary_._keys26135 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "keys", "()Ljava/util/Enumeration;");
		}
		internal static void InitJNI()
		{
		}
	}
}
