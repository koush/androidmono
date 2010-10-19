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
		internal static global::MonoJavaBridge.MethodId _add24163;
		public abstract void add(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _equals24164;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._equals24164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._equals24164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString24165;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._toString24165)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._toString24165)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode24166;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._hashCode24166);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._hashCode24166);
		}
		internal static global::MonoJavaBridge.MethodId _clone24167;
		public abstract global::java.lang.Object clone();
		internal static global::MonoJavaBridge.MethodId _clear24168;
		public abstract void clear();
		internal static global::MonoJavaBridge.MethodId _compare24169;
		public abstract int compare(javax.xml.datatype.XMLGregorianCalendar arg0);
		internal static global::MonoJavaBridge.MethodId _reset24170;
		public abstract void reset();
		internal static global::MonoJavaBridge.MethodId _normalize24171;
		public abstract global::javax.xml.datatype.XMLGregorianCalendar normalize();
		internal static global::MonoJavaBridge.MethodId _setTime24172;
		public virtual void setTime(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime24172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime24172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24173;
		public virtual void setTime(int arg0, int arg1, int arg2, java.math.BigDecimal arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime24173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime24173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setTime24174;
		public virtual void setTime(int arg0, int arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._setTime24174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._setTime24174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getYear24175;
		public abstract int getYear();
		internal static global::MonoJavaBridge.MethodId _getMonth24176;
		public abstract int getMonth();
		internal static global::MonoJavaBridge.MethodId _isValid24177;
		public abstract bool isValid();
		internal static global::MonoJavaBridge.MethodId _getTimeZone24178;
		public abstract global::java.util.TimeZone getTimeZone(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMonth24179;
		public abstract void setMonth(int arg0);
		internal static global::MonoJavaBridge.MethodId _setYear24180;
		public abstract void setYear(int arg0);
		internal static global::MonoJavaBridge.MethodId _setYear24181;
		public abstract void setYear(java.math.BigInteger arg0);
		internal static global::MonoJavaBridge.MethodId _getDay24182;
		public abstract int getDay();
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType24183;
		public abstract global::javax.xml.@namespace.QName getXMLSchemaType();
		internal static global::MonoJavaBridge.MethodId _setDay24184;
		public abstract void setDay(int arg0);
		internal static global::MonoJavaBridge.MethodId _setTimezone24185;
		public abstract void setTimezone(int arg0);
		internal static global::MonoJavaBridge.MethodId _setHour24186;
		public abstract void setHour(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMinute24187;
		public abstract void setMinute(int arg0);
		internal static global::MonoJavaBridge.MethodId _setSecond24188;
		public abstract void setSecond(int arg0);
		internal static global::MonoJavaBridge.MethodId _setMillisecond24189;
		public abstract void setMillisecond(int arg0);
		internal static global::MonoJavaBridge.MethodId _setFractionalSecond24190;
		public abstract void setFractionalSecond(java.math.BigDecimal arg0);
		internal static global::MonoJavaBridge.MethodId _getEon24191;
		public abstract global::java.math.BigInteger getEon();
		internal static global::MonoJavaBridge.MethodId _getEonAndYear24192;
		public abstract global::java.math.BigInteger getEonAndYear();
		internal static global::MonoJavaBridge.MethodId _getTimezone24193;
		public abstract int getTimezone();
		internal static global::MonoJavaBridge.MethodId _getHour24194;
		public abstract int getHour();
		internal static global::MonoJavaBridge.MethodId _getMinute24195;
		public abstract int getMinute();
		internal static global::MonoJavaBridge.MethodId _getSecond24196;
		public abstract int getSecond();
		internal static global::MonoJavaBridge.MethodId _getMillisecond24197;
		public virtual int getMillisecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond24197);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond24197);
		}
		internal static global::MonoJavaBridge.MethodId _getFractionalSecond24198;
		public abstract global::java.math.BigDecimal getFractionalSecond();
		internal static global::MonoJavaBridge.MethodId _toXMLFormat24199;
		public abstract global::java.lang.String toXMLFormat();
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar24200;
		public abstract global::java.util.GregorianCalendar toGregorianCalendar();
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar24201;
		public abstract global::java.util.GregorianCalendar toGregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1, javax.xml.datatype.XMLGregorianCalendar arg2);
		internal static global::MonoJavaBridge.MethodId _XMLGregorianCalendar24202;
		public XMLGregorianCalendar()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.XMLGregorianCalendar.staticClass, global::javax.xml.datatype.XMLGregorianCalendar._XMLGregorianCalendar24202);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.XMLGregorianCalendar.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/XMLGregorianCalendar"));
			global::javax.xml.datatype.XMLGregorianCalendar._add24163 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "add", "(Ljavax/xml/datatype/Duration;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._equals24164 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.xml.datatype.XMLGregorianCalendar._toString24165 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar._hashCode24166 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._clone24167 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.xml.datatype.XMLGregorianCalendar._clear24168 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "clear", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar._compare24169 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I");
			global::javax.xml.datatype.XMLGregorianCalendar._reset24170 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "reset", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar._normalize24171 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime24172 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(III)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime24173 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(IIILjava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTime24174 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTime", "(IIII)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getYear24175 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getYear", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMonth24176 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMonth", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._isValid24177 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "isValid", "()Z");
			global::javax.xml.datatype.XMLGregorianCalendar._getTimeZone24178 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getTimeZone", "(I)Ljava/util/TimeZone;");
			global::javax.xml.datatype.XMLGregorianCalendar._setMonth24179 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMonth", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setYear24180 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setYear", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setYear24181 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setYear", "(Ljava/math/BigInteger;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getDay24182 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getDay", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getXMLSchemaType24183 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getXMLSchemaType", "()Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.XMLGregorianCalendar._setDay24184 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setDay", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setTimezone24185 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setTimezone", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setHour24186 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setHour", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setMinute24187 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMinute", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setSecond24188 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setSecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setMillisecond24189 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setMillisecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar._setFractionalSecond24190 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "setFractionalSecond", "(Ljava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar._getEon24191 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getEon", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar._getEonAndYear24192 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getEonAndYear", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar._getTimezone24193 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getTimezone", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getHour24194 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getHour", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMinute24195 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMinute", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getSecond24196 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getSecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getMillisecond24197 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getMillisecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar._getFractionalSecond24198 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "getFractionalSecond", "()Ljava/math/BigDecimal;");
			global::javax.xml.datatype.XMLGregorianCalendar._toXMLFormat24199 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toXMLFormat", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar._toGregorianCalendar24200 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toGregorianCalendar", "()Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._toGregorianCalendar24201 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar._XMLGregorianCalendar24202 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _add24203;
		public override void add(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._add24203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._add24203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clone24204;
		public override global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._clone24204)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._clone24204)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _clear24205;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._clear24205);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._clear24205);
		}
		internal static global::MonoJavaBridge.MethodId _compare24206;
		public override int compare(javax.xml.datatype.XMLGregorianCalendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._compare24206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._compare24206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _reset24207;
		public override void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._reset24207);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._reset24207);
		}
		internal static global::MonoJavaBridge.MethodId _normalize24208;
		public override global::javax.xml.datatype.XMLGregorianCalendar normalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._normalize24208)) as javax.xml.datatype.XMLGregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._normalize24208)) as javax.xml.datatype.XMLGregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _getYear24209;
		public override int getYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getYear24209);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getYear24209);
		}
		internal static global::MonoJavaBridge.MethodId _getMonth24210;
		public override int getMonth() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getMonth24210);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getMonth24210);
		}
		internal static global::MonoJavaBridge.MethodId _isValid24211;
		public override bool isValid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._isValid24211);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._isValid24211);
		}
		internal static global::MonoJavaBridge.MethodId _getTimeZone24212;
		public override global::java.util.TimeZone getTimeZone(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone24212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone24212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.TimeZone;
		}
		internal static global::MonoJavaBridge.MethodId _setMonth24213;
		public override void setMonth(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMonth24213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMonth24213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear24214;
		public override void setYear(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setYear24214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setYear24214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear24215;
		public override void setYear(java.math.BigInteger arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setYear24215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setYear24215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDay24216;
		public override int getDay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getDay24216);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getDay24216);
		}
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType24217;
		public override global::javax.xml.@namespace.QName getXMLSchemaType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType24217)) as javax.xml.@namespace.QName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType24217)) as javax.xml.@namespace.QName;
		}
		internal static global::MonoJavaBridge.MethodId _setDay24218;
		public override void setDay(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setDay24218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setDay24218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTimezone24219;
		public override void setTimezone(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone24219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone24219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHour24220;
		public override void setHour(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setHour24220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setHour24220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMinute24221;
		public override void setMinute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMinute24221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMinute24221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSecond24222;
		public override void setSecond(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setSecond24222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setSecond24222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMillisecond24223;
		public override void setMillisecond(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond24223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond24223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFractionalSecond24224;
		public override void setFractionalSecond(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond24224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond24224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEon24225;
		public override global::java.math.BigInteger getEon() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getEon24225)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getEon24225)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getEonAndYear24226;
		public override global::java.math.BigInteger getEonAndYear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear24226)) as java.math.BigInteger;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear24226)) as java.math.BigInteger;
		}
		internal static global::MonoJavaBridge.MethodId _getTimezone24227;
		public override int getTimezone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone24227);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone24227);
		}
		internal static global::MonoJavaBridge.MethodId _getHour24228;
		public override int getHour() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getHour24228);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getHour24228);
		}
		internal static global::MonoJavaBridge.MethodId _getMinute24229;
		public override int getMinute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getMinute24229);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getMinute24229);
		}
		internal static global::MonoJavaBridge.MethodId _getSecond24230;
		public override int getSecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getSecond24230);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getSecond24230);
		}
		internal static global::MonoJavaBridge.MethodId _getFractionalSecond24231;
		public override global::java.math.BigDecimal getFractionalSecond() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond24231)) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond24231)) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _toXMLFormat24232;
		public override global::java.lang.String toXMLFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat24232)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat24232)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar24233;
		public override global::java.util.GregorianCalendar toGregorianCalendar() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar24233)) as java.util.GregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar24233)) as java.util.GregorianCalendar;
		}
		internal static global::MonoJavaBridge.MethodId _toGregorianCalendar24234;
		public override global::java.util.GregorianCalendar toGregorianCalendar(java.util.TimeZone arg0, java.util.Locale arg1, javax.xml.datatype.XMLGregorianCalendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar24234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.GregorianCalendar;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar24234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.util.GregorianCalendar;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.XMLGregorianCalendar_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/XMLGregorianCalendar"));
			global::javax.xml.datatype.XMLGregorianCalendar_._add24203 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._clone24204 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "clone", "()Ljava/lang/Object;");
			global::javax.xml.datatype.XMLGregorianCalendar_._clear24205 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "clear", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar_._compare24206 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "compare", "(Ljavax/xml/datatype/XMLGregorianCalendar;)I");
			global::javax.xml.datatype.XMLGregorianCalendar_._reset24207 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "reset", "()V");
			global::javax.xml.datatype.XMLGregorianCalendar_._normalize24208 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "normalize", "()Ljavax/xml/datatype/XMLGregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getYear24209 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getYear", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getMonth24210 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getMonth", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._isValid24211 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "isValid", "()Z");
			global::javax.xml.datatype.XMLGregorianCalendar_._getTimeZone24212 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getTimeZone", "(I)Ljava/util/TimeZone;");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMonth24213 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMonth", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setYear24214 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setYear", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setYear24215 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setYear", "(Ljava/math/BigInteger;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._getDay24216 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getDay", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getXMLSchemaType24217 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getXMLSchemaType", "()Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.XMLGregorianCalendar_._setDay24218 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setDay", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setTimezone24219 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setTimezone", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setHour24220 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setHour", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMinute24221 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMinute", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setSecond24222 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setSecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setMillisecond24223 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setMillisecond", "(I)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._setFractionalSecond24224 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "setFractionalSecond", "(Ljava/math/BigDecimal;)V");
			global::javax.xml.datatype.XMLGregorianCalendar_._getEon24225 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getEon", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getEonAndYear24226 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getEonAndYear", "()Ljava/math/BigInteger;");
			global::javax.xml.datatype.XMLGregorianCalendar_._getTimezone24227 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getTimezone", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getHour24228 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getHour", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getMinute24229 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getMinute", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getSecond24230 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getSecond", "()I");
			global::javax.xml.datatype.XMLGregorianCalendar_._getFractionalSecond24231 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "getFractionalSecond", "()Ljava/math/BigDecimal;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toXMLFormat24232 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toXMLFormat", "()Ljava/lang/String;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar24233 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toGregorianCalendar", "()Ljava/util/GregorianCalendar;");
			global::javax.xml.datatype.XMLGregorianCalendar_._toGregorianCalendar24234 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.XMLGregorianCalendar_.staticClass, "toGregorianCalendar", "(Ljava/util/TimeZone;Ljava/util/Locale;Ljavax/xml/datatype/XMLGregorianCalendar;)Ljava/util/GregorianCalendar;");
		}
	}
}
