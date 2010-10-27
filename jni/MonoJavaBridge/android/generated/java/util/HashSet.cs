namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HashSet : java.util.AbstractSet, Set, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HashSet()
		{
			InitJNI();
		}
		protected HashSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add26257;
		public override bool add(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._add26257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._add26257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone26258;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashSet._clone26258)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._clone26258)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26259;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.HashSet._clear26259);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._clear26259);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26260;
		public override bool isEmpty()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._isEmpty26260);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._isEmpty26260);
		}
		internal static global::MonoJavaBridge.MethodId _contains26261;
		public override bool contains(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._contains26261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._contains26261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26262;
		public override int size()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.HashSet._size26262);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._size26262);
		}
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::java.lang.IterableHelper.WrapIterator(iterator());
		}
		internal static global::MonoJavaBridge.MethodId _iterator26263;
		public override global::java.util.Iterator iterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashSet._iterator26263)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._iterator26263)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26264;
		public override bool remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._remove26264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._remove26264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26265;
		public HashSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26265);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26266;
		public HashSet(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26267;
		public HashSet(int arg0, float arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26268;
		public HashSet(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashSet"));
			global::java.util.HashSet._add26257 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._clone26258 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.HashSet._clear26259 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "clear", "()V");
			global::java.util.HashSet._isEmpty26260 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "isEmpty", "()Z");
			global::java.util.HashSet._contains26261 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._size26262 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "size", "()I");
			global::java.util.HashSet._iterator26263 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.HashSet._remove26264 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._HashSet26265 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "()V");
			global::java.util.HashSet._HashSet26266 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.HashSet._HashSet26267 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(IF)V");
			global::java.util.HashSet._HashSet26268 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(I)V");
		}
	}
}
