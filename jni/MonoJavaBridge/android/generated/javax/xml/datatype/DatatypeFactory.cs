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
		internal static global::MonoJavaBridge.MethodId _newInstance30558;
		public static global::javax.xml.datatype.DatatypeFactory newInstance(java.lang.String arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newInstance30558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as javax.xml.datatype.DatatypeFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newInstance30559;
		public static global::javax.xml.datatype.DatatypeFactory newInstance() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newInstance30559)) as javax.xml.datatype.DatatypeFactory;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30560;
		public abstract global::javax.xml.datatype.Duration newDuration(long arg0);
		internal static global::MonoJavaBridge.MethodId _newDuration30561;
		public abstract global::javax.xml.datatype.Duration newDuration(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigDecimal arg6);
		internal static global::MonoJavaBridge.MethodId _newDuration30562;
		public virtual global::javax.xml.datatype.Duration newDuration(bool arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDuration30562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDuration30562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30563;
		public abstract global::javax.xml.datatype.Duration newDuration(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime30564;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime30565;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime30566;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(bool arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationDayTime30567;
		public virtual global::javax.xml.datatype.Duration newDurationDayTime(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth30568;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth30569;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth30570;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(bool arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDurationYearMonth30571;
		public virtual global::javax.xml.datatype.Duration newDurationYearMonth(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30572;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30573;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.util.GregorianCalendar arg0);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30574;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.math.BigDecimal arg6, int arg7);
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30575;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar30575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar30575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30576;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar();
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarDate30577;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarDate(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarDate30577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarDate30577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime30578;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime30579;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, java.math.BigDecimal arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendarTime30580;
		public virtual global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendarTime(int arg0, int arg1, int arg2, int arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeFactory30581;
		protected DatatypeFactory()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeFactory.staticClass, global::javax.xml.datatype.DatatypeFactory._DatatypeFactory30581);
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
			global::javax.xml.datatype.DatatypeFactory._newInstance30558 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newInstance", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljavax/xml/datatype/DatatypeFactory;");
			global::javax.xml.datatype.DatatypeFactory._newInstance30559 = @__env.GetStaticMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newInstance", "()Ljavax/xml/datatype/DatatypeFactory;");
			global::javax.xml.datatype.DatatypeFactory._newDuration30560 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(J)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDuration30561 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDuration30562 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(ZIIIIII)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDuration30563 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDuration", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30564 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(J)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30565 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30566 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(ZIIII)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationDayTime30567 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationDayTime", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30568 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(J)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30569 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30570 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(ZII)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newDurationYearMonth30571 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newDurationYearMonth", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar30572 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(Ljava/lang/String;)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar30573 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(Ljava/util/GregorianCalendar;)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar30574 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(Ljava/math/BigInteger;IIIIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar30575 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "(IIIIIIII)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendar30576 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarDate30577 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarDate", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30578 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIII)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30579 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._newXMLGregorianCalendarTime30580 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "newXMLGregorianCalendarTime", "(IIIII)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory._DatatypeFactory30581 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _newDuration30584;
		public override global::javax.xml.datatype.Duration newDuration(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newDuration30584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newDuration30584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30585;
		public override global::javax.xml.datatype.Duration newDuration(bool arg0, java.math.BigInteger arg1, java.math.BigInteger arg2, java.math.BigInteger arg3, java.math.BigInteger arg4, java.math.BigInteger arg5, java.math.BigDecimal arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newDuration30585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newDuration30585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newDuration30586;
		public override global::javax.xml.datatype.Duration newDuration(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newDuration30586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newDuration30586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30587;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30588;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.util.GregorianCalendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30589;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar(java.math.BigInteger arg0, int arg1, int arg2, int arg3, int arg4, int arg5, java.math.BigDecimal arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _newXMLGregorianCalendar30590;
		public override global::javax.xml.datatype.XMLGregorianCalendar newXMLGregorianCalendar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30590)) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeFactory_.staticClass, global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30590)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeFactory"));
			global::javax.xml.datatype.DatatypeFactory_._newDuration30584 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(J)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory_._newDuration30585 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(ZLjava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigInteger;Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory_._newDuration30586 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newDuration", "(Ljava/lang/String;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30587 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/lang/String;)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30588 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/util/GregorianCalendar;)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30589 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "(Ljava/math/BigInteger;IIIIILjava/math/BigDecimal;I)Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.DatatypeFactory_._newXMLGregorianCalendar30590 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeFactory_.staticClass, "newXMLGregorianCalendar", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
		}
	}
}
