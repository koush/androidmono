namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractSet_))]
	public abstract partial class AbstractSet : java.util.AbstractCollection, Set
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSet()
		{
			InitJNI();
		}
		protected AbstractSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals19847;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractSet._equals19847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractSet.staticClass, global::java.util.AbstractSet._equals19847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode19848;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractSet._hashCode19848);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractSet.staticClass, global::java.util.AbstractSet._hashCode19848);
		}
		internal static global::MonoJavaBridge.MethodId _removeAll19849;
		public override bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractSet._removeAll19849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractSet.staticClass, global::java.util.AbstractSet._removeAll19849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSet19850;
		protected AbstractSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractSet.staticClass, global::java.util.AbstractSet._AbstractSet19850);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSet"));
			global::java.util.AbstractSet._equals19847 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractSet._hashCode19848 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "hashCode", "()I");
			global::java.util.AbstractSet._removeAll19849 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractSet._AbstractSet19850 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractSet))]
	public sealed partial class AbstractSet_ : java.util.AbstractSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractSet_()
		{
			InitJNI();
		}
		internal AbstractSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size19851;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractSet_._size19851);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractSet_.staticClass, global::java.util.AbstractSet_._size19851);
		}
		internal static global::MonoJavaBridge.MethodId _iterator19852;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractSet_._iterator19852)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractSet_.staticClass, global::java.util.AbstractSet_._iterator19852)) as java.util.Iterator;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSet"));
			global::java.util.AbstractSet_._size19851 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet_.staticClass, "size", "()I");
			global::java.util.AbstractSet_._iterator19852 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
	}
}
