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
		internal static global::MonoJavaBridge.MethodId _get26002;
		public abstract global::java.lang.Object get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _put26003;
		public abstract global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _isEmpty26004;
		public abstract bool isEmpty();
		internal static global::MonoJavaBridge.MethodId _size26005;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _remove26006;
		public abstract global::java.lang.Object remove(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _elements26007;
		public abstract global::java.util.Enumeration elements();
		internal static global::MonoJavaBridge.MethodId _keys26008;
		public abstract global::java.util.Enumeration keys();
		internal static global::MonoJavaBridge.MethodId _Dictionary26009;
		public Dictionary()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Dictionary.staticClass, global::java.util.Dictionary._Dictionary26009);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
			global::java.util.Dictionary._get26002 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._put26003 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._isEmpty26004 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "isEmpty", "()Z");
			global::java.util.Dictionary._size26005 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "size", "()I");
			global::java.util.Dictionary._remove26006 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._elements26007 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary._keys26008 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary._Dictionary26009 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Dictionary))]
	public sealed partial class Dictionary_ : java.util.Dictionary
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Dictionary_()
		{
			InitJNI();
		}
		internal Dictionary_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26010;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._get26010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._get26010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26011;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._put26011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._put26011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26012;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Dictionary_._isEmpty26012);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._isEmpty26012);
		}
		internal static global::MonoJavaBridge.MethodId _size26013;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Dictionary_._size26013);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._size26013);
		}
		internal static global::MonoJavaBridge.MethodId _remove26014;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._remove26014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._remove26014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements26015;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._elements26015)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._elements26015)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys26016;
		public override global::java.util.Enumeration keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._keys26016)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._keys26016)) as java.util.Enumeration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
			global::java.util.Dictionary_._get26010 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._put26011 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._isEmpty26012 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "isEmpty", "()Z");
			global::java.util.Dictionary_._size26013 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "size", "()I");
			global::java.util.Dictionary_._remove26014 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._elements26015 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary_._keys26016 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "keys", "()Ljava/util/Enumeration;");
		}
	}
}
