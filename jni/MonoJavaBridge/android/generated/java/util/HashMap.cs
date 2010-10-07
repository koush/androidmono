namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class HashMap : java.util.AbstractMap, Map, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::java.lang.Class staticClass;
		static HashMap()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.HashMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::java.util.HashMap(@__env);
			}
		}
		protected HashMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get13705;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.HashMap._get13705, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._get13705, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put13706;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.HashMap._put13706, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._put13706, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _values13707;
		public override global::java.util.Collection values() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.HashMap._values13707));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._values13707));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone13708;
		public virtual new global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.HashMap._clone13708));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._clone13708));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13709;
		public override void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.HashMap._clear13709);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._clear13709);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty13710;
		public override bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.HashMap._isEmpty13710);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._isEmpty13710);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size13711;
		public override int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.HashMap._size13711);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._size13711);
		}
		internal static global::net.sf.jni4net.jni.MethodId _entrySet13712;
		public override global::java.util.Set entrySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.HashMap._entrySet13712));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._entrySet13712));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putAll13713;
		public override void putAll(java.util.Map arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.HashMap._putAll13713, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._putAll13713, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove13714;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.HashMap._remove13714, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._remove13714, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keySet13715;
		public override global::java.util.Set keySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.HashMap._keySet13715));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._keySet13715));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsValue13716;
		public override bool containsValue(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.HashMap._containsValue13716, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._containsValue13716, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsKey13717;
		public override bool containsKey(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.HashMap._containsKey13717, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.HashMap.staticClass, global::java.util.HashMap._containsKey13717, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HashMap13718;
		public HashMap(int arg0, float arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap13718, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HashMap13719;
		public HashMap(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap13719, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _HashMap13720;
		public HashMap()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap13720, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _HashMap13721;
		public HashMap(java.util.Map arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.HashMap.staticClass, global::java.util.HashMap._HashMap13721, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.HashMap.staticClass = @__class;
			global::java.util.HashMap._get13705 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._put13706 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._values13707 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.HashMap._clone13708 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.HashMap._clear13709 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "clear", "()V");
			global::java.util.HashMap._isEmpty13710 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "isEmpty", "()Z");
			global::java.util.HashMap._size13711 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "size", "()I");
			global::java.util.HashMap._entrySet13712 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.HashMap._putAll13713 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.HashMap._remove13714 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.HashMap._keySet13715 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.HashMap._containsValue13716 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.HashMap._containsKey13717 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.HashMap._HashMap13718 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(IF)V");
			global::java.util.HashMap._HashMap13719 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(I)V");
			global::java.util.HashMap._HashMap13720 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "()V");
			global::java.util.HashMap._HashMap13721 = @__env.GetMethodID(global::java.util.HashMap.staticClass, "<init>", "(Ljava/util/Map;)V");
		}
	}
}
