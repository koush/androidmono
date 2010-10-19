namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Map_))]
	public interface Map  : global::MonoJavaBridge.IJavaObject 
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
	public sealed partial class Map_ : java.lang.Object, Map
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Map_()
		{
			InitJNI();
		}
		internal Map_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get20558;
		 global::java.lang.Object java.util.Map.get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._get20558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._get20558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put20559;
		 global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._put20559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._put20559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals20560;
		 bool java.util.Map.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._equals20560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._equals20560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values20561;
		 global::java.util.Collection java.util.Map.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._values20561)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._values20561)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20562;
		 int java.util.Map.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Map_._hashCode20562);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._hashCode20562);
		}
		internal static global::MonoJavaBridge.MethodId _clear20563;
		 void java.util.Map.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Map_._clear20563);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._clear20563);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20564;
		 bool java.util.Map.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._isEmpty20564);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._isEmpty20564);
		}
		internal static global::MonoJavaBridge.MethodId _size20565;
		 int java.util.Map.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.Map_._size20565);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._size20565);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet20566;
		 global::java.util.Set java.util.Map.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._entrySet20566)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._entrySet20566)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll20567;
		 void java.util.Map.putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.Map_._putAll20567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._putAll20567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove20568;
		 global::java.lang.Object java.util.Map.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._remove20568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._remove20568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet20569;
		 global::java.util.Set java.util.Map.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Map_._keySet20569)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._keySet20569)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue20570;
		 bool java.util.Map.containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._containsValue20570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._containsValue20570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey20571;
		 bool java.util.Map.containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Map_._containsKey20571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Map_.staticClass, global::java.util.Map_._containsKey20571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Map_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Map"));
			global::java.util.Map_._get20558 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Map_._put20559 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Map_._equals20560 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.Map_._values20561 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.Map_._hashCode20562 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "hashCode", "()I");
			global::java.util.Map_._clear20563 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "clear", "()V");
			global::java.util.Map_._isEmpty20564 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "isEmpty", "()Z");
			global::java.util.Map_._size20565 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "size", "()I");
			global::java.util.Map_._entrySet20566 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.Map_._putAll20567 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.Map_._remove20568 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.Map_._keySet20569 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.Map_._containsValue20570 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.Map_._containsKey20571 = @__env.GetMethodIDNoThrow(global::java.util.Map_.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
		}
	}
}
