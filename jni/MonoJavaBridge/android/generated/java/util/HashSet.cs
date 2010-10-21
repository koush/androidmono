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
		internal static global::MonoJavaBridge.MethodId _add26139;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._add26139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._add26139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone26140;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashSet._clone26140)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._clone26140)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear26141;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.HashSet._clear26141);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._clear26141);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty26142;
		public override bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._isEmpty26142);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._isEmpty26142);
		}
		internal static global::MonoJavaBridge.MethodId _contains26143;
		public override bool contains(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._contains26143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._contains26143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _size26144;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.HashSet._size26144);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._size26144);
		}
		internal static global::MonoJavaBridge.MethodId _iterator26145;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.HashSet._iterator26145)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._iterator26145)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove26146;
		public override bool remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.HashSet._remove26146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.HashSet.staticClass, global::java.util.HashSet._remove26146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26147;
		public HashSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26147);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26148;
		public HashSet(java.util.Collection arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26149;
		public HashSet(int arg0, float arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HashSet26150;
		public HashSet(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.HashSet.staticClass, global::java.util.HashSet._HashSet26150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.HashSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/HashSet"));
			global::java.util.HashSet._add26139 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._clone26140 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.util.HashSet._clear26141 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "clear", "()V");
			global::java.util.HashSet._isEmpty26142 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "isEmpty", "()Z");
			global::java.util.HashSet._contains26143 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "contains", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._size26144 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "size", "()I");
			global::java.util.HashSet._iterator26145 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.HashSet._remove26146 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "remove", "(Ljava/lang/Object;)Z");
			global::java.util.HashSet._HashSet26147 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "()V");
			global::java.util.HashSet._HashSet26148 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::java.util.HashSet._HashSet26149 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(IF)V");
			global::java.util.HashSet._HashSet26150 = @__env.GetMethodIDNoThrow(global::java.util.HashSet.staticClass, "<init>", "(I)V");
		}
	}
}
