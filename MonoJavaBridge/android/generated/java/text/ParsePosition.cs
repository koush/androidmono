namespace java.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParsePosition : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParsePosition(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals25613;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._equals25613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString25614;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._toString25614)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode25615;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._hashCode25615);
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
			set
			{
				setIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex25616;
		public virtual int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._getIndex25616);
		}
		internal static global::MonoJavaBridge.MethodId _setIndex25617;
		public virtual void setIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._setIndex25617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorIndex25618;
		public virtual void setErrorIndex(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._setErrorIndex25618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ErrorIndex
		{
			get
			{
				return getErrorIndex();
			}
			set
			{
				setErrorIndex(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getErrorIndex25619;
		public virtual int getErrorIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.text.ParsePosition.staticClass, global::java.text.ParsePosition._getErrorIndex25619);
		}
		internal static global::MonoJavaBridge.MethodId _ParsePosition25620;
		public ParsePosition(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.ParsePosition.staticClass, global::java.text.ParsePosition._ParsePosition25620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ParsePosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.ParsePosition.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/ParsePosition"));
			global::java.text.ParsePosition._equals25613 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.text.ParsePosition._toString25614 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "toString", "()Ljava/lang/String;");
			global::java.text.ParsePosition._hashCode25615 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "hashCode", "()I");
			global::java.text.ParsePosition._getIndex25616 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "getIndex", "()I");
			global::java.text.ParsePosition._setIndex25617 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "setIndex", "(I)V");
			global::java.text.ParsePosition._setErrorIndex25618 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "setErrorIndex", "(I)V");
			global::java.text.ParsePosition._getErrorIndex25619 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "getErrorIndex", "()I");
			global::java.text.ParsePosition._ParsePosition25620 = @__env.GetMethodIDNoThrow(global::java.text.ParsePosition.staticClass, "<init>", "(I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
