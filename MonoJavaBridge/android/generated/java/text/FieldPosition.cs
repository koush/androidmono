namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FieldPosition : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FieldPosition(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.FieldPosition.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.FieldPosition._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.FieldPosition.staticClass, "toString", "()Ljava/lang/String;", ref global::java.text.FieldPosition._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.FieldPosition.staticClass, "hashCode", "()I", ref global::java.text.FieldPosition._m2);
		}
		public new int Field
		{
			get
			{
				return getField();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getField()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.FieldPosition.staticClass, "getField", "()I", ref global::java.text.FieldPosition._m3);
		}
		public new int BeginIndex
		{
			get
			{
				return getBeginIndex();
			}
			set
			{
				setBeginIndex(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getBeginIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.FieldPosition.staticClass, "getBeginIndex", "()I", ref global::java.text.FieldPosition._m4);
		}
		public new int EndIndex
		{
			get
			{
				return getEndIndex();
			}
			set
			{
				setEndIndex(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getEndIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.FieldPosition.staticClass, "getEndIndex", "()I", ref global::java.text.FieldPosition._m5);
		}
		public new global::java.text.Format.Field FieldAttribute
		{
			get
			{
				return getFieldAttribute();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.text.Format.Field getFieldAttribute()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.FieldPosition.staticClass, "getFieldAttribute", "()Ljava/text/Format$Field;", ref global::java.text.FieldPosition._m6) as java.text.Format.Field;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setBeginIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.FieldPosition.staticClass, "setBeginIndex", "(I)V", ref global::java.text.FieldPosition._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setEndIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.FieldPosition.staticClass, "setEndIndex", "(I)V", ref global::java.text.FieldPosition._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public FieldPosition(java.text.Format.Field arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.FieldPosition._m9.native == global::System.IntPtr.Zero)
				global::java.text.FieldPosition._m9 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public FieldPosition(java.text.Format.Field arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.FieldPosition._m10.native == global::System.IntPtr.Zero)
				global::java.text.FieldPosition._m10 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public FieldPosition(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.FieldPosition._m11.native == global::System.IntPtr.Zero)
				global::java.text.FieldPosition._m11 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FieldPosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.FieldPosition.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/FieldPosition"));
		}
	}
}
