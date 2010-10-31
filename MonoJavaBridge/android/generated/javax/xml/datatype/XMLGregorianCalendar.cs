namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.datatype.XMLGregorianCalendar_))]
	public abstract partial class XMLGregorianCalendar : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected XMLGregorianCalendar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public abstract void add(javax.xml.datatype.Duration arg0);
		private static global::MonoJavaBridge.MethodId _m1;
		public override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::javax.xml.datatype.XMLGregorianCalendar._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.xml.datatype.XMLGregorianCalendar._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "hashCode", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public abstract global::java.lang.Object clone();
		private static global::MonoJavaBridge.MethodId _m5;
		public abstract void clear();
		private static global::MonoJavaBridge.MethodId _m6;
		public abstract int compare(javax.xml.datatype.XMLGregorianCalendar arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		public abstract void reset();
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar normalize();
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setTime(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(III)V", ref global::javax.xml.datatype.XMLGregorianCalendar._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setTime(int arg0, int arg1, int arg2, java.math.BigDecimal arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(IIILjava/math/BigDecimal;)V", ref global::javax.xml.datatype.XMLGregorianCalendar._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setTime(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(IIII)V", ref global::javax.xml.datatype.XMLGregorianCalendar._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public abstract int getYear();
		private static global::MonoJavaBridge.MethodId _m13;
		public abstract int getMonth();
		private static global::MonoJavaBridge.MethodId _m14;
		public abstract bool isValid();
		private static global::MonoJavaBridge.MethodId _m15;
		public abstract global::java.util.TimeZone getTimeZone(int arg0);
		private static global::MonoJavaBridge.MethodId _m16;
		public abstract void setMonth(int arg0);
		private static global::MonoJavaBridge.MethodId _m17;
		public abstract void setYear(int arg0);
		private static global::MonoJavaBridge.MethodId _m18;
		public abstract void setYear(java.math.BigInteger arg0);
		private static global::MonoJavaBridge.MethodId _m19;
		public abstract int getDay();
		private static global::MonoJavaBridge.MethodId _m20;
		public abstract global::javax.xml.@namespace.QName getXMLSchemaType();
		private static global::MonoJavaBridge.MethodId _m21;
		public abstract void setDay(int arg0);
		private static global::MonoJavaBridge.MethodId _m22;
		public abstract void setTimezone(int arg0);
		private static global::MonoJavaBridge.MethodId _m23;
		public abstract void setHour(int arg0);
		private static global::MonoJavaBridge.MethodId _m24;
		public abstract void setMinute(int arg0);
		private static global::MonoJavaBridge.MethodId _m25;
		public abstract void setSecond(int arg0);
		private static global::MonoJavaBridge.MethodId _m26;
		public abstract void setMillisecond(int arg0);
		private static global::MonoJavaBridge.MethodId _m27;
		public abstract void setFractionalSecond(java.math.BigDecimal arg0);
		private static global::MonoJavaBridge.MethodId _m28;
		public abstract global::java.math.BigInteger getEon();
		private static global::MonoJavaBridge.MethodId _m29;
		public abstract global::java.math.BigInteger getEonAndYear();
		private static global::MonoJavaBridge.MethodId _m30;
		public abstract int getTimezone();
		private static global::MonoJavaBridge.MethodId _m31;
		public abstract int getHour();
		private static global::MonoJavaBridge.MethodId _m32;
		public abstract int getMinute();
		private static global::MonoJavaBridge.MethodId _m33;
		public abstract int getSecond();
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual int getMillisecond()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMillisecond", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public abstract global::java.math.BigDecimal getFractionalSecond();
		private static global::MonoJavaBridge.MethodId _m36;
		public abstract global::java.lang.String toXMLFormat();
		private static global::MonoJavaBridge.MethodId _m37;
		public abstract global::java.util.GregorianCalendar toGregorianCalendar();
		private static global::MonoJavaBridge.MethodId _m38;
		public abstract global::java.util.GregorianCalendar toGregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1, javax.xml.datatype.XMLGregorianCalendar arg2);
		private static global::MonoJavaBridge.MethodId _m39;
		public XMLGregorianCalendar() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.XMLGregorianCalendar._m39.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.XMLGregorianCalendar._m39 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._m39);
			Init(@__env, handle);
		}
		static XMLGregorianCalendar()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.XMLGregorianCalendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/XMLGregorianCalendar"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.XMLGregorianCalendar))]
	internal sealed partial class XMLGregorianCalendar_ : javax.xml.datatype.XMLGregorianCalendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal XMLGregorianCalendar_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void add(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "clone", "()Ljava/lang/Object;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "clear", "()V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override int compare(javax.xml.datatype.XMLGregorianCalendar arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I", ref global::javax.xml.datatype.XMLGregorianCalendar_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "reset", "()V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::javax.xml.datatype.XMLGregorianCalendar normalize()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m5) as javax.xml.datatype.XMLGregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getYear()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getYear", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar_._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override int getMonth()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getMonth", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar_._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "isValid", "()Z", ref global::javax.xml.datatype.XMLGregorianCalendar_._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override global::java.util.TimeZone getTimeZone(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getTimeZone", "(I)Ljava/util/TimeZone;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.TimeZone;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override void setMonth(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMonth", "(I)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override void setYear(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setYear", "(I)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override void setYear(java.math.BigInteger arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setYear", "(Ljava/math/BigInteger;)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override int getDay()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getDay", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar_._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override global::javax.xml.@namespace.QName getXMLSchemaType()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getXMLSchemaType", "()Ljavax/xml/namespace/QName;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m14) as javax.xml.@namespace.QName;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void setDay(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setDay", "(I)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void setTimezone(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setTimezone", "(I)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override void setHour(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setHour", "(I)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public override void setMinute(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMinute", "(I)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public override void setSecond(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setSecond", "(I)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public override void setMillisecond(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMillisecond", "(I)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public override void setFractionalSecond(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setFractionalSecond", "(Ljava/math/BigDecimal;)V", ref global::javax.xml.datatype.XMLGregorianCalendar_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public override global::java.math.BigInteger getEon()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getEon", "()Ljava/math/BigInteger;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m22) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public override global::java.math.BigInteger getEonAndYear()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getEonAndYear", "()Ljava/math/BigInteger;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m23) as java.math.BigInteger;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public override int getTimezone()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getTimezone", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar_._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public override int getHour()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getHour", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar_._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public override int getMinute()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getMinute", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar_._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public override int getSecond()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getSecond", "()I", ref global::javax.xml.datatype.XMLGregorianCalendar_._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public override global::java.math.BigDecimal getFractionalSecond()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getFractionalSecond", "()Ljava/math/BigDecimal;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m28) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public override global::java.lang.String toXMLFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toXMLFormat", "()Ljava/lang/String;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m29) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public override global::java.util.GregorianCalendar toGregorianCalendar()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toGregorianCalendar", "()Ljava/util/GregorianCalendar;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m30) as java.util.GregorianCalendar;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public override global::java.util.GregorianCalendar toGregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1, javax.xml.datatype.XMLGregorianCalendar arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)Ljava/util/GregorianCalendar;", ref global::javax.xml.datatype.XMLGregorianCalendar_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.util.GregorianCalendar;
		}
		static XMLGregorianCalendar_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.XMLGregorianCalendar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/XMLGregorianCalendar"));
		}
	}
}
