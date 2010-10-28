namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CopyOnWriteArraySet : java.util.AbstractSet, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static CopyOnWriteArraySet()
		{
			InitJNI();
		}
		protected CopyOnWriteArraySet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add27199;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._add27199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._add27199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals27200;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._equals27200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._equals27200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear27201;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._clear27201);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._clear27201);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty27202;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._isEmpty27202);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._isEmpty27202);
		}
		internal static global::MonoJavaBridge.MethodId _contains27203;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._contains27203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._contains27203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll27204;
		public override bool addAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._addAll27204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._addAll27204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size27205;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._size27205);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._size27205);
		}
		internal static global::MonoJavaBridge.MethodId _toArray27206;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._toArray27206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._toArray27206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray27207;
		public override global::java.lang.Object[] toArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._toArray27207)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._toArray27207)) as java.lang.Object[];
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator27208;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._iterator27208)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._iterator27208)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove27209;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._remove27209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._remove27209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll27210;
		public override bool containsAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._containsAll27210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._containsAll27210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll27211;
		public override bool removeAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._removeAll27211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._removeAll27211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll27212;
		public override bool retainAll(java.util.Collection arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._retainAll27212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._retainAll27212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArraySet27213;
		public CopyOnWriteArraySet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArraySet27214;
		public CopyOnWriteArraySet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27214);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CopyOnWriteArraySet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CopyOnWriteArraySet"));
			global::java.util.concurrent.CopyOnWriteArraySet._add27199 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._equals27200 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._clear27201 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "clear", "()V");
			global::java.util.concurrent.CopyOnWriteArraySet._isEmpty27202 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.CopyOnWriteArraySet._contains27203 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._addAll27204 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._size27205 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "size", "()I");
			global::java.util.concurrent.CopyOnWriteArraySet._toArray27206 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArraySet._toArray27207 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArraySet._iterator27208 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.CopyOnWriteArraySet._remove27209 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._containsAll27210 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._removeAll27211 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._retainAll27212 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27213 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet27214 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "<init>", "()V");
		}
	}
}
