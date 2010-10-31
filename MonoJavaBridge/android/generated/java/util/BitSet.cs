namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BitSet : java.lang.Object, java.lang.Cloneable, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BitSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.util.BitSet get(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.BitSet.staticClass, "get", "(II)Ljava/util/BitSet;", ref global::java.util.BitSet._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.BitSet;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual bool get(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.BitSet.staticClass, "get", "(I)Z", ref global::java.util.BitSet._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.BitSet.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.util.BitSet._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.BitSet.staticClass, "toString", "()Ljava/lang/String;", ref global::java.util.BitSet._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, "hashCode", "()I", ref global::java.util.BitSet._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.BitSet.staticClass, "clone", "()Ljava/lang/Object;", ref global::java.util.BitSet._m5) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void clear(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "clear", "(II)V", ref global::java.util.BitSet._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void clear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "clear", "(I)V", ref global::java.util.BitSet._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "clear", "()V", ref global::java.util.BitSet._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int length()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, "length", "()I", ref global::java.util.BitSet._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual bool isEmpty()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.BitSet.staticClass, "isEmpty", "()Z", ref global::java.util.BitSet._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int size()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, "size", "()I", ref global::java.util.BitSet._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void set(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "set", "(IZ)V", ref global::java.util.BitSet._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void set(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "set", "(II)V", ref global::java.util.BitSet._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void set(int arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "set", "(IIZ)V", ref global::java.util.BitSet._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void set(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "set", "(I)V", ref global::java.util.BitSet._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void flip(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "flip", "(I)V", ref global::java.util.BitSet._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void flip(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "flip", "(II)V", ref global::java.util.BitSet._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual int nextSetBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, "nextSetBit", "(I)I", ref global::java.util.BitSet._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int nextClearBit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, "nextClearBit", "(I)I", ref global::java.util.BitSet._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool intersects(java.util.BitSet arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.BitSet.staticClass, "intersects", "(Ljava/util/BitSet;)Z", ref global::java.util.BitSet._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int cardinality()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.BitSet.staticClass, "cardinality", "()I", ref global::java.util.BitSet._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void and(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "and", "(Ljava/util/BitSet;)V", ref global::java.util.BitSet._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void or(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "or", "(Ljava/util/BitSet;)V", ref global::java.util.BitSet._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void xor(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "xor", "(Ljava/util/BitSet;)V", ref global::java.util.BitSet._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void andNot(java.util.BitSet arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.util.BitSet.staticClass, "andNot", "(Ljava/util/BitSet;)V", ref global::java.util.BitSet._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public BitSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._m26.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._m26 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._m26);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public BitSet(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.BitSet._m27.native == global::System.IntPtr.Zero)
				global::java.util.BitSet._m27 = @__env.GetMethodIDNoThrow(global::java.util.BitSet.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.BitSet.staticClass, global::java.util.BitSet._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static BitSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.BitSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/BitSet"));
		}
	}
}
