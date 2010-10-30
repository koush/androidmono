namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HashMap : java.util.AbstractMap, Map, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HashMap(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26241;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._get26241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26242;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._put26242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _values26243;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._values26243)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clone26244;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._clone26244)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26245;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._clear26245);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26246;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._isEmpty26246);
		}
		internal static global::MonoJavaBridge.MethodId _size26247;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._size26247);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26248;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._entrySet26248)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26249;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._putAll26249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26250;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._remove26250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26251;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._keySet26251)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26252;
		public override bool containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._containsValue26252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26253;
		public override bool containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._containsKey26253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HashMap26254;
		public HashMap(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap26254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap26255;
		public HashMap(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap26255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap26256;
		public HashMap() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap26256);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashMap26257;
		public HashMap(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap26257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static HashMap()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashMap.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashMap"));
			global::java.util.HashMap._get26241 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._put26242 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._values26243 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.HashMap._clone26244 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.HashMap._clear26245 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "clear", "()V");
			global::java.util.HashMap._isEmpty26246 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "isEmpty", "()Z");
			global::java.util.HashMap._size26247 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "size", "()I");
			global::java.util.HashMap._entrySet26248 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.HashMap._putAll26249 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.HashMap._remove26250 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._keySet26251 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.HashMap._containsValue26252 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.HashMap._containsKey26253 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.HashMap._HashMap26254 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(IF)V");
			global::java.util.HashMap._HashMap26255 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(I)V");
			global::java.util.HashMap._HashMap26256 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "()V");
			global::java.util.HashMap._HashMap26257 = @__env.GetMethodIDNoThrow(global::java.util.HashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
