namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractSet_))]
	public abstract partial class AbstractSet : java.util.AbstractCollection, Set
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25742;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractSet._equals25742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractSet.staticClass, global::java.util.AbstractSet._equals25742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25743;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractSet._hashCode25743);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractSet.staticClass, global::java.util.AbstractSet._hashCode25743);
		}
		internal static global::MonoJavaBridge.MethodId _removeAll25744;
		public override bool removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractSet._removeAll25744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractSet.staticClass, global::java.util.AbstractSet._removeAll25744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSet25745;
		protected AbstractSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractSet.staticClass, global::java.util.AbstractSet._AbstractSet25745);
			Init(@__env, handle);
		}
		static AbstractSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSet"));
			global::java.util.AbstractSet._equals25742 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractSet._hashCode25743 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "hashCode", "()I");
			global::java.util.AbstractSet._removeAll25744 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.AbstractSet._AbstractSet25745 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractSet))]
	internal sealed partial class AbstractSet_ : java.util.AbstractSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _size25746;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractSet_._size25746);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractSet_.staticClass, global::java.util.AbstractSet_._size25746);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator25747;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractSet_._iterator25747)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractSet_.staticClass, global::java.util.AbstractSet_._iterator25747)) as java.util.Iterator;
		}
		static AbstractSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractSet"));
			global::java.util.AbstractSet_._size25746 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet_.staticClass, "size", "()I");
			global::java.util.AbstractSet_._iterator25747 = @__env.GetMethodIDNoThrow(global::java.util.AbstractSet_.staticClass, "iterator", "()Ljava/util/Iterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
