namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.ConcurrentMap_))]
	public interface ConcurrentMap : Map
	{
		bool replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2);
		global::java.lang.Object replace(java.lang.Object arg0, java.lang.Object arg1);
		bool remove(java.lang.Object arg0, java.lang.Object arg1);
		global::java.lang.Object putIfAbsent(java.lang.Object arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.ConcurrentMap))]
	public sealed partial class ConcurrentMap_ : java.lang.Object, ConcurrentMap
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ConcurrentMap_()
		{
			InitJNI();
		}
		internal ConcurrentMap_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _replace21198;
		 bool java.util.concurrent.ConcurrentMap.replace(java.lang.Object arg0, java.lang.Object arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._replace21198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._replace21198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _replace21199;
		 global::java.lang.Object java.util.concurrent.ConcurrentMap.replace(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._replace21199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._replace21199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove21200;
		 bool java.util.concurrent.ConcurrentMap.remove(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._remove21200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._remove21200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putIfAbsent21201;
		 global::java.lang.Object java.util.concurrent.ConcurrentMap.putIfAbsent(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._putIfAbsent21201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._putIfAbsent21201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get21202;
		 global::java.lang.Object java.util.Map.get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._get21202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._get21202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put21203;
		 global::java.lang.Object java.util.Map.put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._put21203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._put21203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals21204;
		 bool java.util.Map.equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._equals21204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._equals21204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _values21205;
		 global::java.util.Collection java.util.Map.values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._values21205)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._values21205)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21206;
		 int java.util.Map.hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._hashCode21206);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._hashCode21206);
		}
		internal static global::MonoJavaBridge.MethodId _clear21207;
		 void java.util.Map.clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._clear21207);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._clear21207);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21208;
		 bool java.util.Map.isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._isEmpty21208);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._isEmpty21208);
		}
		internal static global::MonoJavaBridge.MethodId _size21209;
		 int java.util.Map.size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._size21209);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._size21209);
		}
		internal static global::MonoJavaBridge.MethodId _entrySet21210;
		 global::java.util.Set java.util.Map.entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._entrySet21210)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._entrySet21210)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll21211;
		 void java.util.Map.putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._putAll21211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._putAll21211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove21212;
		 global::java.lang.Object java.util.Map.remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._remove21212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._remove21212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keySet21213;
		 global::java.util.Set java.util.Map.keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._keySet21213)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._keySet21213)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsValue21214;
		 bool java.util.Map.containsValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._containsValue21214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._containsValue21214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsKey21215;
		 bool java.util.Map.containsKey(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_._containsKey21215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.ConcurrentMap_.staticClass, global::java.util.concurrent.ConcurrentMap_._containsKey21215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.ConcurrentMap_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/ConcurrentMap"));
			global::java.util.concurrent.ConcurrentMap_._replace21198 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentMap_._replace21199 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentMap_._remove21200 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentMap_._putIfAbsent21201 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentMap_._get21202 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentMap_._put21203 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentMap_._equals21204 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentMap_._values21205 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.concurrent.ConcurrentMap_._hashCode21206 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "hashCode", "()I");
			global::java.util.concurrent.ConcurrentMap_._clear21207 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "clear", "()V");
			global::java.util.concurrent.ConcurrentMap_._isEmpty21208 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.ConcurrentMap_._size21209 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "size", "()I");
			global::java.util.concurrent.ConcurrentMap_._entrySet21210 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.concurrent.ConcurrentMap_._putAll21211 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.concurrent.ConcurrentMap_._remove21212 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.concurrent.ConcurrentMap_._keySet21213 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.concurrent.ConcurrentMap_._containsValue21214 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.ConcurrentMap_._containsKey21215 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.ConcurrentMap_.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
		}
	}
}
