namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class FieldPosition : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected FieldPosition(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25507;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.FieldPosition.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.text.FieldPosition._equals25507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25508;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.text.FieldPosition.staticClass, "toString", "()Ljava/lang/String;", ref global::java.text.FieldPosition._toString25508) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25509;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.FieldPosition.staticClass, "hashCode", "()I", ref global::java.text.FieldPosition._hashCode25509);
		}
		public new int Field
		{
			get
			{
				return getField();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getField25510;
		public virtual int getField()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.FieldPosition.staticClass, "getField", "()I", ref global::java.text.FieldPosition._getField25510);
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
		internal static global::MonoJavaBridge.MethodId _getBeginIndex25511;
		public virtual int getBeginIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.FieldPosition.staticClass, "getBeginIndex", "()I", ref global::java.text.FieldPosition._getBeginIndex25511);
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
		internal static global::MonoJavaBridge.MethodId _getEndIndex25512;
		public virtual int getEndIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.FieldPosition.staticClass, "getEndIndex", "()I", ref global::java.text.FieldPosition._getEndIndex25512);
		}
		public new global::java.text.Format.Field FieldAttribute
		{
			get
			{
				return getFieldAttribute();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldAttribute25513;
		public virtual global::java.text.Format.Field getFieldAttribute()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.FieldPosition.staticClass, "getFieldAttribute", "()Ljava/text/Format$Field;", ref global::java.text.FieldPosition._getFieldAttribute25513) as java.text.Format.Field;
		}
		internal static global::MonoJavaBridge.MethodId _setBeginIndex25514;
		public virtual void setBeginIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.FieldPosition.staticClass, "setBeginIndex", "(I)V", ref global::java.text.FieldPosition._setBeginIndex25514, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEndIndex25515;
		public virtual void setEndIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.FieldPosition.staticClass, "setEndIndex", "(I)V", ref global::java.text.FieldPosition._setEndIndex25515, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition25516;
		public FieldPosition(java.text.Format.Field arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.FieldPosition._FieldPosition25516.native == global::System.IntPtr.Zero)
				global::java.text.FieldPosition._FieldPosition25516 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition25516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition25517;
		public FieldPosition(java.text.Format.Field arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.FieldPosition._FieldPosition25517.native == global::System.IntPtr.Zero)
				global::java.text.FieldPosition._FieldPosition25517 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(Ljava/text/Format$Field;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition25517, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _FieldPosition25518;
		public FieldPosition(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.text.FieldPosition._FieldPosition25518.native == global::System.IntPtr.Zero)
				global::java.text.FieldPosition._FieldPosition25518 = @__env.GetMethodIDNoThrow(global::java.text.FieldPosition.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.FieldPosition.staticClass, global::java.text.FieldPosition._FieldPosition25518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static FieldPosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.FieldPosition.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/FieldPosition"));
		}
		internal static void InitJNI()
		{
		}
	}
}
