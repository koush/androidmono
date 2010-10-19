namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.datatype.Duration_))]
	public abstract partial class Duration : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Duration()
		{
			InitJNI();
		}
		protected Duration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add24126;
		public abstract global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _equals24127;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._equals24127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._equals24127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString24128;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._toString24128)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._toString24128)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode24129;
		public abstract int hashCode();
		internal static global::MonoJavaBridge.MethodId _compare24130;
		public abstract int compare(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _getField24131;
		public abstract global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0);
		internal static global::MonoJavaBridge.MethodId _isSet24132;
		public abstract bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0);
		internal static global::MonoJavaBridge.MethodId _getHours24133;
		public virtual int getHours() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getHours24133);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getHours24133);
		}
		internal static global::MonoJavaBridge.MethodId _getMinutes24134;
		public virtual int getMinutes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getMinutes24134);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getMinutes24134);
		}
		internal static global::MonoJavaBridge.MethodId _getSeconds24135;
		public virtual int getSeconds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getSeconds24135);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getSeconds24135);
		}
		internal static global::MonoJavaBridge.MethodId _subtract24136;
		public virtual global::javax.xml.datatype.Duration subtract(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._subtract24136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._subtract24136, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _multiply24137;
		public virtual global::javax.xml.datatype.Duration multiply(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._multiply24137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._multiply24137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _multiply24138;
		public abstract global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0);
		internal static global::MonoJavaBridge.MethodId _negate24139;
		public abstract global::javax.xml.datatype.Duration negate();
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis24140;
		public virtual long getTimeInMillis(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getTimeInMillis24140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getTimeInMillis24140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis24141;
		public virtual long getTimeInMillis(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getTimeInMillis24141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getTimeInMillis24141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMonths24142;
		public virtual int getMonths() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getMonths24142);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getMonths24142);
		}
		internal static global::MonoJavaBridge.MethodId _getSign24143;
		public abstract int getSign();
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType24144;
		public virtual global::javax.xml.@namespace.QName getXMLSchemaType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getXMLSchemaType24144)) as javax.xml.@namespace.QName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getXMLSchemaType24144)) as javax.xml.@namespace.QName;
		}
		internal static global::MonoJavaBridge.MethodId _getYears24145;
		public virtual int getYears() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getYears24145);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getYears24145);
		}
		internal static global::MonoJavaBridge.MethodId _getDays24146;
		public virtual int getDays() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getDays24146);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getDays24146);
		}
		internal static global::MonoJavaBridge.MethodId _addTo24147;
		public abstract void addTo(java.util.Calendar arg0);
		internal static global::MonoJavaBridge.MethodId _addTo24148;
		public virtual void addTo(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration._addTo24148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._addTo24148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalizeWith24149;
		public abstract global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0);
		internal static global::MonoJavaBridge.MethodId _isLongerThan24150;
		public virtual bool isLongerThan(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._isLongerThan24150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._isLongerThan24150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShorterThan24151;
		public virtual bool isShorterThan(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._isShorterThan24151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._isShorterThan24151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Duration24152;
		public Duration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._Duration24152);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
			global::javax.xml.datatype.Duration._add24126 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._equals24127 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.xml.datatype.Duration._toString24128 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.xml.datatype.Duration._hashCode24129 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.Duration._compare24130 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "compare", "(Ljavax/xml/datatype/Duration;)I");
			global::javax.xml.datatype.Duration._getField24131 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;");
			global::javax.xml.datatype.Duration._isSet24132 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z");
			global::javax.xml.datatype.Duration._getHours24133 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getHours", "()I");
			global::javax.xml.datatype.Duration._getMinutes24134 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getMinutes", "()I");
			global::javax.xml.datatype.Duration._getSeconds24135 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getSeconds", "()I");
			global::javax.xml.datatype.Duration._subtract24136 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "subtract", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._multiply24137 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "multiply", "(I)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._multiply24138 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._negate24139 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "negate", "()Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._getTimeInMillis24140 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Calendar;)J");
			global::javax.xml.datatype.Duration._getTimeInMillis24141 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Date;)J");
			global::javax.xml.datatype.Duration._getMonths24142 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getMonths", "()I");
			global::javax.xml.datatype.Duration._getSign24143 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getSign", "()I");
			global::javax.xml.datatype.Duration._getXMLSchemaType24144 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getXMLSchemaType", "()Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.Duration._getYears24145 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getYears", "()I");
			global::javax.xml.datatype.Duration._getDays24146 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getDays", "()I");
			global::javax.xml.datatype.Duration._addTo24147 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "addTo", "(Ljava/util/Calendar;)V");
			global::javax.xml.datatype.Duration._addTo24148 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "addTo", "(Ljava/util/Date;)V");
			global::javax.xml.datatype.Duration._normalizeWith24149 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._isLongerThan24150 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isLongerThan", "(Ljavax/xml/datatype/Duration;)Z");
			global::javax.xml.datatype.Duration._isShorterThan24151 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isShorterThan", "(Ljavax/xml/datatype/Duration;)Z");
			global::javax.xml.datatype.Duration._Duration24152 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.Duration))]
	public sealed partial class Duration_ : javax.xml.datatype.Duration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Duration_()
		{
			InitJNI();
		}
		internal Duration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add24153;
		public override global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._add24153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._add24153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode24154;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._hashCode24154);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._hashCode24154);
		}
		internal static global::MonoJavaBridge.MethodId _compare24155;
		public override int compare(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._compare24155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._compare24155, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getField24156;
		public override global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._getField24156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._getField24156, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _isSet24157;
		public override bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._isSet24157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._isSet24157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _multiply24158;
		public override global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._multiply24158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._multiply24158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _negate24159;
		public override global::javax.xml.datatype.Duration negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._negate24159)) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._negate24159)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _getSign24160;
		public override int getSign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._getSign24160);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._getSign24160);
		}
		internal static global::MonoJavaBridge.MethodId _addTo24161;
		public override void addTo(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._addTo24161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._addTo24161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalizeWith24162;
		public override global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._normalizeWith24162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._normalizeWith24162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
			global::javax.xml.datatype.Duration_._add24153 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._hashCode24154 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.Duration_._compare24155 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "compare", "(Ljavax/xml/datatype/Duration;)I");
			global::javax.xml.datatype.Duration_._getField24156 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;");
			global::javax.xml.datatype.Duration_._isSet24157 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z");
			global::javax.xml.datatype.Duration_._multiply24158 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._negate24159 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "negate", "()Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._getSign24160 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "getSign", "()I");
			global::javax.xml.datatype.Duration_._addTo24161 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "addTo", "(Ljava/util/Calendar;)V");
			global::javax.xml.datatype.Duration_._normalizeWith24162 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;");
		}
	}
}
