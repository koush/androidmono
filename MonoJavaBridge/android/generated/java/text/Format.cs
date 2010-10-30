namespace java.text
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.text.Format_))]
	public abstract partial class Format : java.lang.Object, java.io.Serializable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Format(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Field : java.text.AttributedCharacterIterator_Attribute
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Field25519;
			protected Field(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Format.Field.staticClass, global::java.text.Format.Field._Field25519, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static Field()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.text.Format.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Format$Field"));
				global::java.text.Format.Field._Field25519 = @__env.GetMethodIDNoThrow(global::java.text.Format.Field.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _clone25520;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.Format.staticClass, global::java.text.Format._clone25520)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _format25521;
		public virtual global::java.lang.String format(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.Format.staticClass, global::java.text.Format._format25521, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _format25522;
		public abstract global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2);
		internal static global::MonoJavaBridge.MethodId _parseObject25523;
		public virtual global::java.lang.Object parseObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.Format.staticClass, global::java.text.Format._parseObject25523, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _parseObject25524;
		public abstract global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1);
		internal static global::MonoJavaBridge.MethodId _formatToCharacterIterator25525;
		public virtual global::java.text.AttributedCharacterIterator formatToCharacterIterator(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.text.AttributedCharacterIterator>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.text.Format.staticClass, global::java.text.Format._formatToCharacterIterator25525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.text.AttributedCharacterIterator;
		}
		internal static global::MonoJavaBridge.MethodId _Format25526;
		protected Format() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.text.Format.staticClass, global::java.text.Format._Format25526);
			Init(@__env, handle);
		}
		static Format()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Format.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Format"));
			global::java.text.Format._clone25520 = @__env.GetMethodIDNoThrow(global::java.text.Format.staticClass, "clone", "()Ljava/lang/Object;");
			global::java.text.Format._format25521 = @__env.GetMethodIDNoThrow(global::java.text.Format.staticClass, "format", "(Ljava/lang/Object;)Ljava/lang/String;");
			global::java.text.Format._format25522 = @__env.GetMethodIDNoThrow(global::java.text.Format.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.Format._parseObject25523 = @__env.GetMethodIDNoThrow(global::java.text.Format.staticClass, "parseObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::java.text.Format._parseObject25524 = @__env.GetMethodIDNoThrow(global::java.text.Format.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
			global::java.text.Format._formatToCharacterIterator25525 = @__env.GetMethodIDNoThrow(global::java.text.Format.staticClass, "formatToCharacterIterator", "(Ljava/lang/Object;)Ljava/text/AttributedCharacterIterator;");
			global::java.text.Format._Format25526 = @__env.GetMethodIDNoThrow(global::java.text.Format.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.text.Format))]
	internal sealed partial class Format_ : java.text.Format
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Format_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _format25527;
		public override global::java.lang.StringBuffer format(java.lang.Object arg0, java.lang.StringBuffer arg1, java.text.FieldPosition arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.StringBuffer>(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Format_._format25527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.StringBuffer;
		}
		internal static global::MonoJavaBridge.MethodId _parseObject25528;
		public override global::java.lang.Object parseObject(java.lang.String arg0, java.text.ParsePosition arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.text.Format_._parseObject25528, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		static Format_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.text.Format_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/text/Format"));
			global::java.text.Format_._format25527 = @__env.GetMethodIDNoThrow(global::java.text.Format_.staticClass, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;");
			global::java.text.Format_._parseObject25528 = @__env.GetMethodIDNoThrow(global::java.text.Format_.staticClass, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
