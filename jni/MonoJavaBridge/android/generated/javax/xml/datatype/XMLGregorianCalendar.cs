namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.datatype.XMLGregorianCalendar_))]
	public abstract partial class XMLGregorianCalendar : java.lang.Object, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLGregorianCalendar()
		{
			InitJNI();
		}
		protected XMLGregorianCalendar(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add30628;
		public abstract void add(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _equals30629;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._equals30629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._equals30629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30630;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._toString30630)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._toString30630)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30631;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._hashCode30631);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._hashCode30631);
		}
		internal static global::MonoJavaBridge.MethodId _clone30632;
		public abstract global::java.lang.Object clone();
		internal static global::MonoJavaBridge.MethodId _clear30633;
		public abstract void clear();
		internal static global::MonoJavaBridge.MethodId _compare30634;
		public abstract int compare(javax.xml.datatype.XMLGregorianCalendar arg0);
		internal static global::MonoJavaBridge.MethodId _reset30635;
		public abstract void reset();
		internal static global::MonoJavaBridge.MethodId _normalize30636;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar normalize();
		internal static global::MonoJavaBridge.MethodId _setTime30637;
		public virtual void setTime(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime30637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime30637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime30638;
		public virtual void setTime(int arg0, int arg1, int arg2, java.math.BigDecimal arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime30638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime30638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setTime30639;
		public virtual void setTime(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime30639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime30639, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getYear30640;
		public abstract int getYear();
		internal static global::MonoJavaBridge.MethodId _getMonth30641;
		public abstract int getMonth();
		internal static global::MonoJavaBridge.MethodId _isValid30642;
		public abstract bool isValid();
		internal static global::MonoJavaBridge.MethodId _getTimeZone30643;
		public abstract global::java.util.TimeZone getTimeZone(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMonth30644;
		public abstract void setMonth(int arg0);
		internal static global::MonoJavaBridge.MethodId _setYear30645;
		public abstract void setYear(int arg0);
		internal static global::MonoJavaBridge.MethodId _setYear30646;
		public abstract void setYear(java.math.BigInteger arg0);
		internal static global::MonoJavaBridge.MethodId _getDay30647;
		public abstract int getDay();
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType30648;
		public abstract global::javax.xml.@namespace.QName getXMLSchemaType();
		internal static global::MonoJavaBridge.MethodId _setDay30649;
		public abstract void setDay(int arg0);
		internal static global::MonoJavaBridge.MethodId _setTimezone30650;
		public abstract void setTimezone(int arg0);
		internal static global::MonoJavaBridge.MethodId _setHour30651;
		public abstract void setHour(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMinute30652;
		public abstract void setMinute(int arg0);
		internal static global::MonoJavaBridge.MethodId _setSecond30653;
		public abstract void setSecond(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMillisecond30654;
		public abstract void setMillisecond(int arg0);
		internal static global::MonoJavaBridge.MethodId _setFractionalSecond30655;
		public abstract void setFractionalSecond(java.math.BigDecimal arg0);
		internal static global::MonoJavaBridge.MethodId _getEon30656;
		public abstract global::java.math.BigInteger getEon();
		internal static global::MonoJavaBridge.MethodId _getEonAndYear30657;
		public abstract global::java.math.BigInteger getEonAndYear();
		internal static global::MonoJavaBridge.MethodId _getTimezone30658;
		public abstract int getTimezone();
		internal static global::MonoJavaBridge.MethodId _getHour30659;
		public abstract int getHour();
		internal static global::MonoJavaBridge.MethodId _getMinute30660;
		public abstract int getMinute();
		internal static global::MonoJavaBridge.MethodId _getSecond30661;
		public abstract int getSecond();
		internal static global::MonoJavaBridge.MethodId _getMillisecond30662;
		public virtual int getMillisecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond30662);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond30662);
		}
		internal static global::MonoJavaBridge.MethodId _getFractionalSecond30663;
		public abstract global::java.math.BigDecimal getFractionalSecond();
		internal static global::MonoJavaBridge.MethodId _toXMLFormat30664;
		public abstract global::java.lang.String toXMLFormat();
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar30665;
		public abstract global::java.util.GregorianCalendar toGregorianCalendar();
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar30666;
		public abstract global::java.util.GregorianCalendar toGregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1, javax.xml.datatype.XMLGregorianCalendar arg2);
		internal static global::MonoJavaBridge.MethodId _XMLGregorianCalendar30667;
		public XMLGregorianCalendar()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._XMLGregorianCalendar30667);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.XMLGregorianCalendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/XMLGregorianCalendar"));
			global::javax.xml.datatype.XMLGregorianCalendar._add30628 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "add", "(Ljavax/xml/datatype/Duration;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._equals30629 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.xml.datatype.XMLGregorianCalendar._toString30630 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar._hashCode30631 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._clone30632 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.xml.datatype.XMLGregorianCalendar._clear30633 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "clear", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar._compare30634 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I");
			global::javax.xml.datatype.XMLGregorianCalendar._reset30635 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "reset", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar._normalize30636 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime30637 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(III)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime30638 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(IIILjava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime30639 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(IIII)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getYear30640 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getYear", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMonth30641 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMonth", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._isValid30642 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "isValid", "()Z");
			global::javax.xml.datatype.XMLGregorianCalendar._getTimeZone30643 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getTimeZone", "(I)Ljava/util/TimeZone;");
			global::javax.xml.datatype.XMLGregorianCalendar._setMonth30644 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMonth", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setYear30645 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setYear", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setYear30646 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setYear", "(Ljava/math/BigInteger;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getDay30647 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getDay", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getXMLSchemaType30648 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getXMLSchemaType", "()Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.XMLGregorianCalendar._setDay30649 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setDay", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTimezone30650 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTimezone", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setHour30651 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setHour", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setMinute30652 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMinute", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setSecond30653 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setSecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setMillisecond30654 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMillisecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setFractionalSecond30655 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setFractionalSecond", "(Ljava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getEon30656 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getEon", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar._getEonAndYear30657 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getEonAndYear", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar._getTimezone30658 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getTimezone", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getHour30659 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getHour", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMinute30660 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMinute", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getSecond30661 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getSecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond30662 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMillisecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getFractionalSecond30663 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getFractionalSecond", "()Ljava/math/BigDecimal;");
			global::javax.xml.datatype.XMLGregorianCalendar._toXMLFormat30664 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toXMLFormat", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar._toGregorianCalendar30665 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toGregorianCalendar", "()Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._toGregorianCalendar30666 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._XMLGregorianCalendar30667 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.XMLGregorianCalendar))]
	public sealed partial class XMLGregorianCalendar_ : javax.xml.datatype.XMLGregorianCalendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLGregorianCalendar_()
		{
			InitJNI();
		}
		internal XMLGregorianCalendar_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add30668;
		public override void add(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._add30668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._add30668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone30669;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._clone30669)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._clone30669)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear30670;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._clear30670);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._clear30670);
		}
		internal static global::MonoJavaBridge.MethodId _compare30671;
		public override int compare(javax.xml.datatype.XMLGregorianCalendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._compare30671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._compare30671, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset30672;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._reset30672);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._reset30672);
		}
		internal static global::MonoJavaBridge.MethodId _normalize30673;
		public override global::javax.xml.datatype.XMLGregorianCalendar normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._normalize30673)) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._normalize30673)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _getYear30674;
		public override int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getYear30674);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getYear30674);
		}
		internal static global::MonoJavaBridge.MethodId _getMonth30675;
		public override int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getMonth30675);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getMonth30675);
		}
		internal static global::MonoJavaBridge.MethodId _isValid30676;
		public override bool isValid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._isValid30676);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._isValid30676);
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone30677;
		public override global::java.util.TimeZone getTimeZone(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone30677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone30677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setMonth30678;
		public override void setMonth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMonth30678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMonth30678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear30679;
		public override void setYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setYear30679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setYear30679, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear30680;
		public override void setYear(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setYear30680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setYear30680, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDay30681;
		public override int getDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getDay30681);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getDay30681);
		}
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType30682;
		public override global::javax.xml.@namespace.QName getXMLSchemaType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType30682)) as javax.xml.@namespace.QName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType30682)) as javax.xml.@namespace.QName;
		}
		internal static global::MonoJavaBridge.MethodId _setDay30683;
		public override void setDay(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setDay30683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setDay30683, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTimezone30684;
		public override void setTimezone(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone30684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone30684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHour30685;
		public override void setHour(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setHour30685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setHour30685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinute30686;
		public override void setMinute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMinute30686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMinute30686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecond30687;
		public override void setSecond(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setSecond30687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setSecond30687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMillisecond30688;
		public override void setMillisecond(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond30688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond30688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFractionalSecond30689;
		public override void setFractionalSecond(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond30689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond30689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEon30690;
		public override global::java.math.BigInteger getEon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getEon30690)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getEon30690)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEonAndYear30691;
		public override global::java.math.BigInteger getEonAndYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear30691)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear30691)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getTimezone30692;
		public override int getTimezone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone30692);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone30692);
		}
		internal static global::MonoJavaBridge.MethodId _getHour30693;
		public override int getHour() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getHour30693);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getHour30693);
		}
		internal static global::MonoJavaBridge.MethodId _getMinute30694;
		public override int getMinute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getMinute30694);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getMinute30694);
		}
		internal static global::MonoJavaBridge.MethodId _getSecond30695;
		public override int getSecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getSecond30695);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getSecond30695);
		}
		internal static global::MonoJavaBridge.MethodId _getFractionalSecond30696;
		public override global::java.math.BigDecimal getFractionalSecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond30696)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond30696)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toXMLFormat30697;
		public override global::java.lang.String toXMLFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat30697)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat30697)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar30698;
		public override global::java.util.GregorianCalendar toGregorianCalendar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30698)) as java.util.GregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30698)) as java.util.GregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar30699;
		public override global::java.util.GregorianCalendar toGregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1, javax.xml.datatype.XMLGregorianCalendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.GregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.GregorianCalendar;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.XMLGregorianCalendar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/XMLGregorianCalendar"));
			global::javax.xml.datatype.XMLGregorianCalendar_._add30668 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._clone30669 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.xml.datatype.XMLGregorianCalendar_._clear30670 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "clear", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar_._compare30671 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I");
			global::javax.xml.datatype.XMLGregorianCalendar_._reset30672 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "reset", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar_._normalize30673 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getYear30674 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getYear", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getMonth30675 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getMonth", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._isValid30676 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "isValid", "()Z");
			global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone30677 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getTimeZone", "(I)Ljava/util/TimeZone;");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMonth30678 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMonth", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setYear30679 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setYear", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setYear30680 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setYear", "(Ljava/math/BigInteger;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._getDay30681 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getDay", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType30682 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getXMLSchemaType", "()Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.XMLGregorianCalendar_._setDay30683 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setDay", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone30684 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setTimezone", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setHour30685 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setHour", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMinute30686 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMinute", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setSecond30687 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setSecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond30688 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMillisecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond30689 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setFractionalSecond", "(Ljava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._getEon30690 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getEon", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear30691 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getEonAndYear", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone30692 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getTimezone", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getHour30693 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getHour", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getMinute30694 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getMinute", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getSecond30695 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getSecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond30696 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getFractionalSecond", "()Ljava/math/BigDecimal;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat30697 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toXMLFormat", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30698 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toGregorianCalendar", "()Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30699 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)Ljava/util/GregorianCalendar;");
		}
	}
}
