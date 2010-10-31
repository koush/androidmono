namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ArrayList : java.util.AbstractList, List, RandomAccess, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ArrayList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void add(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, "add", "(ILjava/lang/Object;)V", ref global::java.util.ArrayList._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool add(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, "add", "(Ljava/lang/Object;)Z", ref global::java.util.ArrayList._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.Object get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ArrayList.staticClass, "get", "(I)Ljava/lang/Object;", ref global::java.util.ArrayList._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ArrayList.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.ArrayList._m3) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int indexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.ArrayList.staticClass, "indexOf", "(Ljava/lang/Object;)I", ref global::java.util.ArrayList._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, "clear", "()V", ref global::java.util.ArrayList._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, "isEmpty", "()Z", ref global::java.util.ArrayList._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int lastIndexOf(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.ArrayList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I", ref global::java.util.ArrayList._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool contains(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, "contains", "(Ljava/lang/Object;)Z", ref global::java.util.ArrayList._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override bool addAll(java.util.Collection arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, "addAll", "(Ljava/util/Collection;)Z", ref global::java.util.ArrayList._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override bool addAll(int arg0, java.util.Collection arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, "addAll", "(ILjava/util/Collection;)Z", ref global::java.util.ArrayList._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.ArrayList.staticClass, "size", "()I", ref global::java.util.ArrayList._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.lang.Object[] toArray(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.ArrayList.staticClass, "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", ref global::java.util.ArrayList._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::java.lang.Object[] toArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::java.util.ArrayList.staticClass, "toArray", "()[Ljava/lang/Object;", ref global::java.util.ArrayList._m13) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::java.lang.Object remove(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ArrayList.staticClass, "remove", "(I)Ljava/lang/Object;", ref global::java.util.ArrayList._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override bool remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.ArrayList.staticClass, "remove", "(Ljava/lang/Object;)Z", ref global::java.util.ArrayList._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override global::java.lang.Object set(int arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ArrayList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;", ref global::java.util.ArrayList._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void trimToSize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, "trimToSize", "()V", ref global::java.util.ArrayList._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void ensureCapacity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, "ensureCapacity", "(I)V", ref global::java.util.ArrayList._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected override void removeRange(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.ArrayList.staticClass, "removeRange", "(II)V", ref global::java.util.ArrayList._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public ArrayList(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._m20.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._m20 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public ArrayList() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._m21.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._m21 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._m21);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public ArrayList(java.util.Collection arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ArrayList._m22.native == global::System.IntPtr.Zero)
				global::java.util.ArrayList._m22 = @__env.GetMethodIDNoThrow(global::java.util.ArrayList.staticClass, "<init>", "(Ljava/util/Collection;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.ArrayList.staticClass, global::java.util.ArrayList._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ArrayList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ArrayList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ArrayList"));
		}
	}
}
