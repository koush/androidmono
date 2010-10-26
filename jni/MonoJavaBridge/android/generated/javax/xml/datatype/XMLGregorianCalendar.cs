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
		internal static global::MonoJavaBridge.MethodId _add30746;
		public abstract void add(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _equals30747;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._equals30747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._equals30747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30748;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._toString30748)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._toString30748)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30749;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._hashCode30749);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._hashCode30749);
		}
		internal static global::MonoJavaBridge.MethodId _clone30750;
		public abstract global::java.lang.Object clone();
		internal static global::MonoJavaBridge.MethodId _clear30751;
		public abstract void clear();
		internal static global::MonoJavaBridge.MethodId _compare30752;
		public abstract int compare(javax.xml.datatype.XMLGregorianCalendar arg0);
		internal static global::MonoJavaBridge.MethodId _reset30753;
		public abstract void reset();
		internal static global::MonoJavaBridge.MethodId _normalize30754;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar normalize();
		internal static global::MonoJavaBridge.MethodId _setTime30755;
		public virtual void setTime(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime30755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime30755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime30756;
		public virtual void setTime(int arg0, int arg1, int arg2, java.math.BigDecimal arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime30756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime30756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setTime30757;
		public virtual void setTime(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime30757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime30757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getYear30758;
		public abstract int getYear();
		internal static global::MonoJavaBridge.MethodId _getMonth30759;
		public abstract int getMonth();
		internal static global::MonoJavaBridge.MethodId _isValid30760;
		public abstract bool isValid();
		internal static global::MonoJavaBridge.MethodId _getTimeZone30761;
		public abstract global::java.util.TimeZone getTimeZone(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMonth30762;
		public abstract void setMonth(int arg0);
		internal static global::MonoJavaBridge.MethodId _setYear30763;
		public abstract void setYear(int arg0);
		internal static global::MonoJavaBridge.MethodId _setYear30764;
		public abstract void setYear(java.math.BigInteger arg0);
		internal static global::MonoJavaBridge.MethodId _getDay30765;
		public abstract int getDay();
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType30766;
		public abstract global::javax.xml.@namespace.QName getXMLSchemaType();
		internal static global::MonoJavaBridge.MethodId _setDay30767;
		public abstract void setDay(int arg0);
		internal static global::MonoJavaBridge.MethodId _setTimezone30768;
		public abstract void setTimezone(int arg0);
		internal static global::MonoJavaBridge.MethodId _setHour30769;
		public abstract void setHour(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMinute30770;
		public abstract void setMinute(int arg0);
		internal static global::MonoJavaBridge.MethodId _setSecond30771;
		public abstract void setSecond(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMillisecond30772;
		public abstract void setMillisecond(int arg0);
		internal static global::MonoJavaBridge.MethodId _setFractionalSecond30773;
		public abstract void setFractionalSecond(java.math.BigDecimal arg0);
		internal static global::MonoJavaBridge.MethodId _getEon30774;
		public abstract global::java.math.BigInteger getEon();
		internal static global::MonoJavaBridge.MethodId _getEonAndYear30775;
		public abstract global::java.math.BigInteger getEonAndYear();
		internal static global::MonoJavaBridge.MethodId _getTimezone30776;
		public abstract int getTimezone();
		internal static global::MonoJavaBridge.MethodId _getHour30777;
		public abstract int getHour();
		internal static global::MonoJavaBridge.MethodId _getMinute30778;
		public abstract int getMinute();
		internal static global::MonoJavaBridge.MethodId _getSecond30779;
		public abstract int getSecond();
		internal static global::MonoJavaBridge.MethodId _getMillisecond30780;
		public virtual int getMillisecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond30780);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond30780);
		}
		internal static global::MonoJavaBridge.MethodId _getFractionalSecond30781;
		public abstract global::java.math.BigDecimal getFractionalSecond();
		internal static global::MonoJavaBridge.MethodId _toXMLFormat30782;
		public abstract global::java.lang.String toXMLFormat();
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar30783;
		public abstract global::java.util.GregorianCalendar toGregorianCalendar();
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar30784;
		public abstract global::java.util.GregorianCalendar toGregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1, javax.xml.datatype.XMLGregorianCalendar arg2);
		internal static global::MonoJavaBridge.MethodId _XMLGregorianCalendar30785;
		public XMLGregorianCalendar()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._XMLGregorianCalendar30785);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.XMLGregorianCalendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/XMLGregorianCalendar"));
			global::javax.xml.datatype.XMLGregorianCalendar._add30746 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "add", "(Ljavax/xml/datatype/Duration;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._equals30747 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.xml.datatype.XMLGregorianCalendar._toString30748 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar._hashCode30749 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._clone30750 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.xml.datatype.XMLGregorianCalendar._clear30751 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "clear", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar._compare30752 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I");
			global::javax.xml.datatype.XMLGregorianCalendar._reset30753 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "reset", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar._normalize30754 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime30755 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(III)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime30756 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(IIILjava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime30757 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(IIII)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getYear30758 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getYear", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMonth30759 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMonth", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._isValid30760 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "isValid", "()Z");
			global::javax.xml.datatype.XMLGregorianCalendar._getTimeZone30761 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getTimeZone", "(I)Ljava/util/TimeZone;");
			global::javax.xml.datatype.XMLGregorianCalendar._setMonth30762 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMonth", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setYear30763 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setYear", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setYear30764 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setYear", "(Ljava/math/BigInteger;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getDay30765 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getDay", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getXMLSchemaType30766 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getXMLSchemaType", "()Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.XMLGregorianCalendar._setDay30767 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setDay", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTimezone30768 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTimezone", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setHour30769 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setHour", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setMinute30770 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMinute", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setSecond30771 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setSecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setMillisecond30772 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMillisecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setFractionalSecond30773 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setFractionalSecond", "(Ljava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getEon30774 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getEon", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar._getEonAndYear30775 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getEonAndYear", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar._getTimezone30776 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getTimezone", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getHour30777 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getHour", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMinute30778 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMinute", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getSecond30779 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getSecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond30780 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMillisecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getFractionalSecond30781 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getFractionalSecond", "()Ljava/math/BigDecimal;");
			global::javax.xml.datatype.XMLGregorianCalendar._toXMLFormat30782 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toXMLFormat", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar._toGregorianCalendar30783 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toGregorianCalendar", "()Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._toGregorianCalendar30784 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._XMLGregorianCalendar30785 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.XMLGregorianCalendar))]
	internal sealed partial class XMLGregorianCalendar_ : javax.xml.datatype.XMLGregorianCalendar
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XMLGregorianCalendar_()
		{
			InitJNI();
		}
		internal XMLGregorianCalendar_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add30786;
		public override void add(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._add30786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._add30786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone30787;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._clone30787)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._clone30787)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear30788;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._clear30788);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._clear30788);
		}
		internal static global::MonoJavaBridge.MethodId _compare30789;
		public override int compare(javax.xml.datatype.XMLGregorianCalendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._compare30789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._compare30789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset30790;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._reset30790);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._reset30790);
		}
		internal static global::MonoJavaBridge.MethodId _normalize30791;
		public override global::javax.xml.datatype.XMLGregorianCalendar normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._normalize30791)) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._normalize30791)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _getYear30792;
		public override int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getYear30792);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getYear30792);
		}
		internal static global::MonoJavaBridge.MethodId _getMonth30793;
		public override int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getMonth30793);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getMonth30793);
		}
		internal static global::MonoJavaBridge.MethodId _isValid30794;
		public override bool isValid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._isValid30794);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._isValid30794);
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone30795;
		public override global::java.util.TimeZone getTimeZone(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone30795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone30795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setMonth30796;
		public override void setMonth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMonth30796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMonth30796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear30797;
		public override void setYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setYear30797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setYear30797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear30798;
		public override void setYear(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setYear30798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setYear30798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDay30799;
		public override int getDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getDay30799);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getDay30799);
		}
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType30800;
		public override global::javax.xml.@namespace.QName getXMLSchemaType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType30800)) as javax.xml.@namespace.QName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType30800)) as javax.xml.@namespace.QName;
		}
		internal static global::MonoJavaBridge.MethodId _setDay30801;
		public override void setDay(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setDay30801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setDay30801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTimezone30802;
		public override void setTimezone(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone30802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone30802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHour30803;
		public override void setHour(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setHour30803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setHour30803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinute30804;
		public override void setMinute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMinute30804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMinute30804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecond30805;
		public override void setSecond(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setSecond30805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setSecond30805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMillisecond30806;
		public override void setMillisecond(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond30806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond30806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFractionalSecond30807;
		public override void setFractionalSecond(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond30807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond30807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEon30808;
		public override global::java.math.BigInteger getEon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getEon30808)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getEon30808)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEonAndYear30809;
		public override global::java.math.BigInteger getEonAndYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear30809)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear30809)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getTimezone30810;
		public override int getTimezone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone30810);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone30810);
		}
		internal static global::MonoJavaBridge.MethodId _getHour30811;
		public override int getHour() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getHour30811);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getHour30811);
		}
		internal static global::MonoJavaBridge.MethodId _getMinute30812;
		public override int getMinute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getMinute30812);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getMinute30812);
		}
		internal static global::MonoJavaBridge.MethodId _getSecond30813;
		public override int getSecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getSecond30813);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getSecond30813);
		}
		internal static global::MonoJavaBridge.MethodId _getFractionalSecond30814;
		public override global::java.math.BigDecimal getFractionalSecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond30814)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond30814)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toXMLFormat30815;
		public override global::java.lang.String toXMLFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat30815)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat30815)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar30816;
		public override global::java.util.GregorianCalendar toGregorianCalendar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30816)) as java.util.GregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30816)) as java.util.GregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar30817;
		public override global::java.util.GregorianCalendar toGregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1, javax.xml.datatype.XMLGregorianCalendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.GregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.GregorianCalendar;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.XMLGregorianCalendar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/XMLGregorianCalendar"));
			global::javax.xml.datatype.XMLGregorianCalendar_._add30786 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._clone30787 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.xml.datatype.XMLGregorianCalendar_._clear30788 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "clear", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar_._compare30789 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I");
			global::javax.xml.datatype.XMLGregorianCalendar_._reset30790 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "reset", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar_._normalize30791 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getYear30792 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getYear", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getMonth30793 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getMonth", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._isValid30794 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "isValid", "()Z");
			global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone30795 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getTimeZone", "(I)Ljava/util/TimeZone;");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMonth30796 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMonth", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setYear30797 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setYear", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setYear30798 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setYear", "(Ljava/math/BigInteger;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._getDay30799 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getDay", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType30800 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getXMLSchemaType", "()Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.XMLGregorianCalendar_._setDay30801 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setDay", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone30802 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setTimezone", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setHour30803 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setHour", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMinute30804 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMinute", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setSecond30805 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setSecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond30806 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMillisecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond30807 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setFractionalSecond", "(Ljava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._getEon30808 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getEon", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear30809 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getEonAndYear", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone30810 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getTimezone", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getHour30811 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getHour", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getMinute30812 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getMinute", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getSecond30813 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getSecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond30814 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getFractionalSecond", "()Ljava/math/BigDecimal;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat30815 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toXMLFormat", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30816 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toGregorianCalendar", "()Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar30817 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)Ljava/util/GregorianCalendar;");
		}
	}
}
