namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Map_))]
	public partial interface Map  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object get(java.lang.Object arg0);
		global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1);
		bool equals(java.lang.Object arg0);
		global::java.util.Collection values();
		int hashCode();
		void clear();
		bool isEmpty();
		int size();
		global::java.util.Set entrySet();
		void putAll(java.util.Map arg0);
		global::java.lang.Object remove(java.lang.Object arg0);
		global::java.util.Set keySet();
		bool containsValue(java.lang.Object arg0);
		bool containsKey(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Map))]
	internal sealed partial class Map_ : java.lang.Object, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Map_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get26502;
		global::java.lang.Object java.util.Map.get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Map_._get26502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put26503;
		global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Map_._put26503, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals26504;
		bool java.util.Map.equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Map_.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.Map_._equals26504, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values26505;
		global::java.util.Collection java.util.Map.values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.util.Map_.staticClass, "values", "()Ljava/util/Collection;", ref global::java.util.Map_._values26505) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode26506;
		int java.util.Map.hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Map_.staticClass, "hashCode", "()I", ref global::java.util.Map_._hashCode26506);
		}
		internal static global::MonoJavaBridge.MethodId _clear26507;
		void java.util.Map.clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Map_.staticClass, "clear", "()V", ref global::java.util.Map_._clear26507);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26508;
		bool java.util.Map.isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Map_.staticClass, "isEmpty", "()Z", ref global::java.util.Map_._isEmpty26508);
		}
		internal static global::MonoJavaBridge.MethodId _size26509;
		int java.util.Map.size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.Map_.staticClass, "size", "()I", ref global::java.util.Map_._size26509);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet26510;
		global::java.util.Set java.util.Map.entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.Map_.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.util.Map_._entrySet26510) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll26511;
		void java.util.Map.putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.Map_.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.util.Map_._putAll26511, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove26512;
		global::java.lang.Object java.util.Map.remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.Map_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.util.Map_._remove26512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet26513;
		global::java.util.Set java.util.Map.keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.util.Map_.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.util.Map_._keySet26513) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue26514;
		bool java.util.Map.containsValue(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Map_.staticClass, "containsValue", "(Ljava/lang/Object;)Z", ref global::java.util.Map_._containsValue26514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey26515;
		bool java.util.Map.containsKey(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.Map_.staticClass, "containsKey", "(Ljava/lang/Object;)Z", ref global::java.util.Map_._containsKey26515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Map_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Map_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Map"));
		}
		internal static void InitJNI()
		{
		}
	}
}
