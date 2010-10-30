namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.datatype.DatatypeFactory_))]
	public abstract partial class DatatypeFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatatypeFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30677;
		public static global::javax.xml.datatype.DatatypeFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeFactory._newInstance30677.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeFactory._newInstance30677 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/datatype/DatatypeFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newInstance30677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.datatype.DatatypeFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30678;
		public static global::javax.xml.datatype.DatatypeFactory newInstance()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeFactory._newInstance30678.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeFactory._newInstance30678 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newInstance", "()Ljavax/xml/datatype/DatatypeFactory;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newInstance30678)) as javax.xml.datatype.DatatypeFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30679;
		public abstract global::javax.xml.datatype.Duration newDuration(long arg0);
		internal static global::MonoJavaBridge.MethodId _newDuration30680;
		public abstract global::javax.xml.datatype.Duration newDuration(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigDecimal arg6);
		internal static global::MonoJavaBridge.MethodId _newDuration30681;
		public virtual global::javax.xml.datatype.Duration newDuration(bool arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(ZIIIIII)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDuration30681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30682;
		public abstract global::javax.xml.datatype.Duration newDuration(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime30683;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(J)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime30684;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime30685;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(bool arg0, int arg1, int arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(ZIIII)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime30686;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth30687;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(J)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth30688;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth30689;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(bool arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(ZII)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth30690;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30691;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30692;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.util.GregorianCalendar arg0);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30693;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.math.BigDecimal arg6, int arg7);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30694;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(IIIIIIII)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar30694, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30695;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar();
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarDate30696;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarDate(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarDate", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarDate30696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime30697;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30697, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime30698;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, java.math.BigDecimal arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30698, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime30699;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIIII)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeFactory30700;
		protected DatatypeFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeFactory._DatatypeFactory30700.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeFactory._DatatypeFactory30700 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._DatatypeFactory30700);
			Init(@__env, handle);
		}
		public static global::java.lang.String DATATYPEFACTORY_PROPERTY
		{
			get
			{
				return "javax.xml.datatype.DatatypeFactory";
			}
		}
		public static global::java.lang.String DATATYPEFACTORY_IMPLEMENTATION_CLASS
		{
			get
			{
				return "com.sun.org.apache.xerces.internal.jaxp.datatype.DatatypeFactoryImpl";
			}
		}
		static DatatypeFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeFactory"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.DatatypeFactory))]
	internal sealed partial class DatatypeFactory_ : javax.xml.datatype.DatatypeFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatatypeFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30703;
		public override global::javax.xml.datatype.Duration newDuration(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(J)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory_._newDuration30703, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30704;
		public override global::javax.xml.datatype.Duration newDuration(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigDecimal arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory_._newDuration30704, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30705;
		public override global::javax.xml.datatype.Duration newDuration(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;", ref global::javax.xml.datatype.DatatypeFactory_._newDuration30705, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30706;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/lang/String;)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30706, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30707;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.util.GregorianCalendar arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/util/GregorianCalendar;)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30707, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30708;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.math.BigDecimal arg6, int arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/math/BigInteger;IIIIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30708, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30709;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30709) as javax.xml.datatype.XMLGregorianCalendar;
		}
		static DatatypeFactory_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
