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
		internal static global::MonoJavaBridge.MethodId _add21250;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._add21250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._add21250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _equals21251;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._equals21251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._equals21251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear21252;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._clear21252);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._clear21252);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty21253;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._isEmpty21253);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._isEmpty21253);
		}
		internal static global::MonoJavaBridge.MethodId _contains21254;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._contains21254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._contains21254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll21255;
		public override bool addAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._addAll21255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._addAll21255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size21256;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._size21256);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._size21256);
		}
		internal static global::MonoJavaBridge.MethodId _toArray21257;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._toArray21257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._toArray21257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _toArray21258;
		public override global::java.lang.Object[] toArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._toArray21258)) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._toArray21258)) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _iterator21259;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._iterator21259)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._iterator21259)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove21260;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._remove21260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._remove21260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _containsAll21261;
		public override bool containsAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._containsAll21261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._containsAll21261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeAll21262;
		public override bool removeAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._removeAll21262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._removeAll21262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _retainAll21263;
		public override bool retainAll(java.util.Collection arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet._retainAll21263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._retainAll21263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArraySet21264;
		public CopyOnWriteArraySet(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet21264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CopyOnWriteArraySet21265;
		public CopyOnWriteArraySet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.concurrent.CopyOnWriteArraySet.staticClass, global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet21265);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.CopyOnWriteArraySet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/CopyOnWriteArraySet"));
			global::java.util.concurrent.CopyOnWriteArraySet._add21250 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._equals21251 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._clear21252 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "clear", "()V");
			global::java.util.concurrent.CopyOnWriteArraySet._isEmpty21253 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "isEmpty", "()Z");
			global::java.util.concurrent.CopyOnWriteArraySet._contains21254 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._addAll21255 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "addAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._size21256 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "size", "()I");
			global::java.util.concurrent.CopyOnWriteArraySet._toArray21257 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArraySet._toArray21258 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "toArray", "()[Ljava/lang/Object;");
			global::java.util.concurrent.CopyOnWriteArraySet._iterator21259 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.concurrent.CopyOnWriteArraySet._remove21260 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._containsAll21261 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "containsAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._removeAll21262 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "removeAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._retainAll21263 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "retainAll", "(Ljava/util/Collection;)Z");
			global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet21264 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.concurrent.CopyOnWriteArraySet._CopyOnWriteArraySet21265 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.CopyOnWriteArraySet.staticClass, "<init>", "()V");
		}
	}
}
