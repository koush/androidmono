namespace java.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AbstractMap : java.lang.Object, Map
	{
		internal static global::java.lang.Class staticClass;
		static AbstractMap()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.util.AbstractMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected AbstractMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get13520;
		public virtual global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractMap._get13520, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._get13520, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put13521;
		public virtual global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractMap._put13521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._put13521, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals13522;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractMap._equals13522, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._equals13522, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13523;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractMap._toString13523));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._toString13523));
		}
		internal static global::net.sf.jni4net.jni.MethodId _values13524;
		public virtual global::java.util.Collection values() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractMap._values13524));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._values13524));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode13525;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.AbstractMap._hashCode13525);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._hashCode13525);
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13526;
		public virtual void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.AbstractMap._clear13526);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._clear13526);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty13527;
		public virtual bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractMap._isEmpty13527);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._isEmpty13527);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size13528;
		public virtual int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::java.util.AbstractMap._size13528);
			else
				return @__env.CallNonVirtualIntMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._size13528);
		}
		internal static global::net.sf.jni4net.jni.MethodId _entrySet13529;
		public abstract global::java.util.Set entrySet();
		internal static global::net.sf.jni4net.jni.MethodId _putAll13530;
		public virtual void putAll(java.util.Map arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.util.AbstractMap._putAll13530, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._putAll13530, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove13531;
		public virtual global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractMap._remove13531, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._remove13531, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keySet13532;
		public virtual global::java.util.Set keySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.util.AbstractMap._keySet13532));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._keySet13532));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsValue13533;
		public virtual bool containsValue(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractMap._containsValue13533, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._containsValue13533, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsKey13534;
		public virtual bool containsKey(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::java.util.AbstractMap._containsKey13534, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::java.util.AbstractMap.staticClass, global::java.util.AbstractMap._containsKey13534, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AbstractMap13535;
		protected AbstractMap()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.util.AbstractMap.staticClass, global::java.util.AbstractMap._AbstractMap13535, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.util.AbstractMap.staticClass = @__class;
			global::java.util.AbstractMap._get13520 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._put13521 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._equals13522 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._toString13523 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "toString", "()Ljava/lang/String;");
			global::java.util.AbstractMap._values13524 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "values", "()Ljava/util/Collection;");
			global::java.util.AbstractMap._hashCode13525 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "hashCode", "()I");
			global::java.util.AbstractMap._clear13526 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "clear", "()V");
			global::java.util.AbstractMap._isEmpty13527 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "isEmpty", "()Z");
			global::java.util.AbstractMap._size13528 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "size", "()I");
			global::java.util.AbstractMap._entrySet13529 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.util.AbstractMap._putAll13530 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.util.AbstractMap._remove13531 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractMap._keySet13532 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.util.AbstractMap._containsValue13533 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "containsValue", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._containsKey13534 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "containsKey", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractMap._AbstractMap13535 = @__env.GetMethodID(global::java.util.AbstractMap.staticClass, "<init>", "()V");
		}
	}
}
