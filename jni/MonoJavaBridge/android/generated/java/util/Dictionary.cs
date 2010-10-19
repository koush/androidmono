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
		internal static global::MonoJavaBridge.MethodId _get20182;
		public abstract global::java.lang.Object get(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _put20183;
		public abstract global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1);
		internal static global::MonoJavaBridge.MethodId _isEmpty20184;
		public abstract bool isEmpty();
		internal static global::MonoJavaBridge.MethodId _size20185;
		public abstract int size();
		internal static global::MonoJavaBridge.MethodId _remove20186;
		public abstract global::java.lang.Object remove(java.lang.Object arg0);
		internal static global::MonoJavaBridge.MethodId _elements20187;
		public abstract global::java.util.Enumeration elements();
		internal static global::MonoJavaBridge.MethodId _keys20188;
		public abstract global::java.util.Enumeration keys();
		internal static global::MonoJavaBridge.MethodId _Dictionary20189;
		public Dictionary()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.Dictionary.staticClass, global::java.util.Dictionary._Dictionary20189);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
			global::java.util.Dictionary._get20182 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._put20183 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._isEmpty20184 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "isEmpty", "()Z");
			global::java.util.Dictionary._size20185 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "size", "()I");
			global::java.util.Dictionary._remove20186 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary._elements20187 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary._keys20188 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary._Dictionary20189 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _get20190;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._get20190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._get20190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put20191;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._put20191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._put20191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20192;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Dictionary_._isEmpty20192);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._isEmpty20192);
		}
		internal static global::MonoJavaBridge.MethodId _size20193;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Dictionary_._size20193);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._size20193);
		}
		internal static global::MonoJavaBridge.MethodId _remove20194;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._remove20194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._remove20194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements20195;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._elements20195)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._elements20195)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys20196;
		public override global::java.util.Enumeration keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Dictionary_._keys20196)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Dictionary_.staticClass, global::java.util.Dictionary_._keys20196)) as java.util.Enumeration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Dictionary_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Dictionary"));
			global::java.util.Dictionary_._get20190 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._put20191 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._isEmpty20192 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "isEmpty", "()Z");
			global::java.util.Dictionary_._size20193 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "size", "()I");
			global::java.util.Dictionary_._remove20194 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Dictionary_._elements20195 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.util.Dictionary_._keys20196 = @__env.GetMethodIDNoThrow(global::java.util.Dictionary_.staticClass, "keys", "()Ljava/util/Enumeration;");
		}
	}
}
