namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.Buffer_))]
	public abstract partial class Buffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Buffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int limit()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer.staticClass, "limit", "()I", ref global::java.nio.Buffer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.nio.Buffer limit(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, "limit", "(I)Ljava/nio/Buffer;", ref global::java.nio.Buffer._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.Buffer;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.nio.Buffer clear()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, "clear", "()Ljava/nio/Buffer;", ref global::java.nio.Buffer._m2) as java.nio.Buffer;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int remaining()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer.staticClass, "remaining", "()I", ref global::java.nio.Buffer._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract bool hasArray();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.lang.Object array();
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.nio.Buffer position(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, "position", "(I)Ljava/nio/Buffer;", ref global::java.nio.Buffer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.Buffer;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int position()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer.staticClass, "position", "()I", ref global::java.nio.Buffer._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract int arrayOffset();
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int capacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer.staticClass, "capacity", "()I", ref global::java.nio.Buffer._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::java.nio.Buffer mark()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, "mark", "()Ljava/nio/Buffer;", ref global::java.nio.Buffer._m10) as java.nio.Buffer;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.nio.Buffer reset()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, "reset", "()Ljava/nio/Buffer;", ref global::java.nio.Buffer._m11) as java.nio.Buffer;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.nio.Buffer flip()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, "flip", "()Ljava/nio/Buffer;", ref global::java.nio.Buffer._m12) as java.nio.Buffer;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.nio.Buffer rewind()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, "rewind", "()Ljava/nio/Buffer;", ref global::java.nio.Buffer._m13) as java.nio.Buffer;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual bool hasRemaining()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.Buffer.staticClass, "hasRemaining", "()Z", ref global::java.nio.Buffer._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract bool isReadOnly();
		static Buffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.Buffer))]
	internal sealed partial class Buffer_ : java.nio.Buffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Buffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool hasArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.Buffer_.staticClass, "hasArray", "()Z", ref global::java.nio.Buffer_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object array()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer_.staticClass, "array", "()Ljava/lang/Object;", ref global::java.nio.Buffer_._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int arrayOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer_.staticClass, "arrayOffset", "()I", ref global::java.nio.Buffer_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.Buffer_.staticClass, "isReadOnly", "()Z", ref global::java.nio.Buffer_._m3);
		}
		static Buffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
