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
		internal static global::MonoJavaBridge.MethodId _add20314;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._add20314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._add20314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone20315;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashSet._clone20315)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._clone20315)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear20316;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.HashSet._clear20316);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._clear20316);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty20317;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._isEmpty20317);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._isEmpty20317);
		}
		internal static global::MonoJavaBridge.MethodId _contains20318;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._contains20318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._contains20318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size20319;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.HashSet._size20319);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._size20319);
		}
		internal static global::MonoJavaBridge.MethodId _iterator20320;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashSet._iterator20320)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._iterator20320)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove20321;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._remove20321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._remove20321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HashSet20322;
		public HashSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet20322);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet20323;
		public HashSet(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet20323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet20324;
		public HashSet(int arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet20324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet20325;
		public HashSet(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet20325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashSet"));
			global::java.util.HashSet._add20314 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._clone20315 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.HashSet._clear20316 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "clear", "()V");
			global::java.util.HashSet._isEmpty20317 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "isEmpty", "()Z");
			global::java.util.HashSet._contains20318 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._size20319 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "size", "()I");
			global::java.util.HashSet._iterator20320 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.HashSet._remove20321 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._HashSet20322 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "()V");
			global::java.util.HashSet._HashSet20323 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.HashSet._HashSet20324 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(IF)V");
			global::java.util.HashSet._HashSet20325 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(I)V");
		}
	}
}
