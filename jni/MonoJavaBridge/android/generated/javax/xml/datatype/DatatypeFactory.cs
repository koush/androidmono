namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.datatype.DatatypeFactory_))]
	public abstract partial class DatatypeFactory : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatatypeFactory()
		{
			InitJNI();
		}
		protected DatatypeFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24095;
		public static global::javax.xml.datatype.DatatypeFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newInstance24095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.datatype.DatatypeFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance24096;
		public static global::javax.xml.datatype.DatatypeFactory newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newInstance24096)) as javax.xml.datatype.DatatypeFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration24097;
		public abstract global::javax.xml.datatype.Duration newDuration(long arg0);
		internal static global::MonoJavaBridge.MethodId _newDuration24098;
		public abstract global::javax.xml.datatype.Duration newDuration(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigDecimal arg6);
		internal static global::MonoJavaBridge.MethodId _newDuration24099;
		public virtual global::javax.xml.datatype.Duration newDuration(bool arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDuration24099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDuration24099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration24100;
		public abstract global::javax.xml.datatype.Duration newDuration(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime24101;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime24102;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime24103;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime24104;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth24105;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth24106;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth24107;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(bool arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth24108;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24109;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24110;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.util.GregorianCalendar arg0);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24111;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.math.BigDecimal arg6, int arg7);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24112;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar24112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar24112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24113;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar();
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarDate24114;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarDate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarDate24114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarDate24114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime24115;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime24116;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, java.math.BigDecimal arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime24117;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeFactory24118;
		protected DatatypeFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._DatatypeFactory24118);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeFactory"));
			global::javax.xml.datatype.DatatypeFactory._newInstance24095 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/datatype/DatatypeFactory;");
			global::javax.xml.datatype.DatatypeFactory._newInstance24096 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newInstance", "()Ljavax/xml/datatype/DatatypeFactory;");
			global::javax.xml.datatype.DatatypeFactory._newDuration24097 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(J)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDuration24098 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDuration24099 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(ZIIIIII)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDuration24100 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24101 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(J)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24102 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24103 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(ZIIII)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationDayTime24104 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24105 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(J)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24106 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24107 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(ZII)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth24108 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar24109 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(Ljava/lang/String;)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar24110 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(Ljava/util/GregorianCalendar;)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar24111 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(Ljava/math/BigInteger;IIIIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar24112 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(IIIIIIII)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar24113 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarDate24114 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarDate", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24115 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24116 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime24117 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIIII)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._DatatypeFactory24118 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.DatatypeFactory))]
	public sealed partial class DatatypeFactory_ : javax.xml.datatype.DatatypeFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatatypeFactory_()
		{
			InitJNI();
		}
		internal DatatypeFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newDuration24119;
		public override global::javax.xml.datatype.Duration newDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newDuration24119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newDuration24119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration24120;
		public override global::javax.xml.datatype.Duration newDuration(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigDecimal arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newDuration24120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newDuration24120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration24121;
		public override global::javax.xml.datatype.Duration newDuration(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newDuration24121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newDuration24121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24122;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24123;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.util.GregorianCalendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24124;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.math.BigDecimal arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar24125;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24125)) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24125)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeFactory"));
			global::javax.xml.datatype.DatatypeFactory_._newDuration24119 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(J)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory_._newDuration24120 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory_._newDuration24121 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24122 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/lang/String;)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24123 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/util/GregorianCalendar;)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24124 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/math/BigInteger;IIIIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar24125 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
		}
	}
}
