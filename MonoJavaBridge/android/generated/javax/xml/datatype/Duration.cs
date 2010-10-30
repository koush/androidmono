namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.datatype.Duration_))]
	public abstract partial class Duration : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Duration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.Duration.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.xml.datatype.Duration._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.datatype.Duration.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.xml.datatype.Duration._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public abstract int hashCode();
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract int compare(javax.xml.datatype.Duration arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0);
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getHours()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, "getHours", "()I", ref global::javax.xml.datatype.Duration._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getMinutes()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, "getMinutes", "()I", ref global::javax.xml.datatype.Duration._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getSeconds()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, "getSeconds", "()I", ref global::javax.xml.datatype.Duration._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::javax.xml.datatype.Duration subtract(javax.xml.datatype.Duration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration.staticClass, "subtract", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.Duration._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::javax.xml.datatype.Duration multiply(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration.staticClass, "multiply", "(I)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.Duration._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0);
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract global::javax.xml.datatype.Duration negate();
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual long getTimeInMillis(java.util.Calendar arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Calendar;)J", ref global::javax.xml.datatype.Duration._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual long getTimeInMillis(java.util.Date arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Date;)J", ref global::javax.xml.datatype.Duration._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int getMonths()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, "getMonths", "()I", ref global::javax.xml.datatype.Duration._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract int getSign();
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::javax.xml.@namespace.QName getXMLSchemaType()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration.staticClass, "getXMLSchemaType", "()Ljavax/xml/namespace/QName;", ref global::javax.xml.datatype.Duration._m18) as javax.xml.@namespace.QName;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getYears()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, "getYears", "()I", ref global::javax.xml.datatype.Duration._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int getDays()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, "getDays", "()I", ref global::javax.xml.datatype.Duration._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract void addTo(java.util.Calendar arg0);
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void addTo(java.util.Date arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.Duration.staticClass, "addTo", "(Ljava/util/Date;)V", ref global::javax.xml.datatype.Duration._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0);
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual bool isLongerThan(javax.xml.datatype.Duration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.Duration.staticClass, "isLongerThan", "(Ljavax/xml/datatype/Duration;)Z", ref global::javax.xml.datatype.Duration._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool isShorterThan(javax.xml.datatype.Duration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.Duration.staticClass, "isShorterThan", "(Ljavax/xml/datatype/Duration;)Z", ref global::javax.xml.datatype.Duration._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public Duration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._m26.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._m26 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._m26);
			Init(@__env, handle);
		}
		static Duration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.Duration))]
	internal sealed partial class Duration_ : javax.xml.datatype.Duration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Duration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.Duration_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration_.staticClass, "hashCode", "()I", ref global::javax.xml.datatype.Duration_._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override int compare(javax.xml.datatype.Duration arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration_.staticClass, "compare", "(Ljavax/xml/datatype/Duration;)I", ref global::javax.xml.datatype.Duration_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration_.staticClass, "getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;", ref global::javax.xml.datatype.Duration_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Number;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.Duration_.staticClass, "isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z", ref global::javax.xml.datatype.Duration_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration_.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.Duration_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::javax.xml.datatype.Duration negate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration_.staticClass, "negate", "()Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.Duration_._m6) as javax.xml.datatype.Duration;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getSign()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration_.staticClass, "getSign", "()I", ref global::javax.xml.datatype.Duration_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void addTo(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.Duration_.staticClass, "addTo", "(Ljava/util/Calendar;)V", ref global::javax.xml.datatype.Duration_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration_.staticClass, "normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.Duration_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		static Duration_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
		}
		internal static void InitJNI()
		{
		}
	}
}
