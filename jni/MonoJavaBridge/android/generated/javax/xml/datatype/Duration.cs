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
		internal static global::MonoJavaBridge.MethodId _add30709;
		public abstract global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _equals30710;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._equals30710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._equals30710, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30711;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._toString30711)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._toString30711)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30712;
		public abstract int hashCode();
		internal static global::MonoJavaBridge.MethodId _compare30713;
		public abstract int compare(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _getField30714;
		public abstract global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0);
		internal static global::MonoJavaBridge.MethodId _isSet30715;
		public abstract bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0);
		internal static global::MonoJavaBridge.MethodId _getHours30716;
		public virtual int getHours()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getHours30716);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getHours30716);
		}
		internal static global::MonoJavaBridge.MethodId _getMinutes30717;
		public virtual int getMinutes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getMinutes30717);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getMinutes30717);
		}
		internal static global::MonoJavaBridge.MethodId _getSeconds30718;
		public virtual int getSeconds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getSeconds30718);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getSeconds30718);
		}
		internal static global::MonoJavaBridge.MethodId _subtract30719;
		public virtual global::javax.xml.datatype.Duration subtract(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._subtract30719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._subtract30719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _multiply30720;
		public virtual global::javax.xml.datatype.Duration multiply(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._multiply30720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._multiply30720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _multiply30721;
		public abstract global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0);
		internal static global::MonoJavaBridge.MethodId _negate30722;
		public abstract global::javax.xml.datatype.Duration negate();
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis30723;
		public virtual long getTimeInMillis(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getTimeInMillis30723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getTimeInMillis30723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis30724;
		public virtual long getTimeInMillis(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getTimeInMillis30724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getTimeInMillis30724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMonths30725;
		public virtual int getMonths()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getMonths30725);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getMonths30725);
		}
		internal static global::MonoJavaBridge.MethodId _getSign30726;
		public abstract int getSign();
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType30727;
		public virtual global::javax.xml.@namespace.QName getXMLSchemaType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getXMLSchemaType30727)) as javax.xml.@namespace.QName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getXMLSchemaType30727)) as javax.xml.@namespace.QName;
		}
		internal static global::MonoJavaBridge.MethodId _getYears30728;
		public virtual int getYears()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getYears30728);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getYears30728);
		}
		internal static global::MonoJavaBridge.MethodId _getDays30729;
		public virtual int getDays()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getDays30729);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getDays30729);
		}
		internal static global::MonoJavaBridge.MethodId _addTo30730;
		public abstract void addTo(java.util.Calendar arg0);
		internal static global::MonoJavaBridge.MethodId _addTo30731;
		public virtual void addTo(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration._addTo30731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._addTo30731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalizeWith30732;
		public abstract global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0);
		internal static global::MonoJavaBridge.MethodId _isLongerThan30733;
		public virtual bool isLongerThan(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._isLongerThan30733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._isLongerThan30733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShorterThan30734;
		public virtual bool isShorterThan(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._isShorterThan30734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._isShorterThan30734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Duration30735;
		public Duration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._Duration30735);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
			global::javax.xml.datatype.Duration._add30709 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._equals30710 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.xml.datatype.Duration._toString30711 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.xml.datatype.Duration._hashCode30712 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.Duration._compare30713 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "compare", "(Ljavax/xml/datatype/Duration;)I");
			global::javax.xml.datatype.Duration._getField30714 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;");
			global::javax.xml.datatype.Duration._isSet30715 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z");
			global::javax.xml.datatype.Duration._getHours30716 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getHours", "()I");
			global::javax.xml.datatype.Duration._getMinutes30717 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getMinutes", "()I");
			global::javax.xml.datatype.Duration._getSeconds30718 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getSeconds", "()I");
			global::javax.xml.datatype.Duration._subtract30719 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "subtract", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._multiply30720 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "multiply", "(I)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._multiply30721 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._negate30722 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "negate", "()Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._getTimeInMillis30723 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Calendar;)J");
			global::javax.xml.datatype.Duration._getTimeInMillis30724 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Date;)J");
			global::javax.xml.datatype.Duration._getMonths30725 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getMonths", "()I");
			global::javax.xml.datatype.Duration._getSign30726 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getSign", "()I");
			global::javax.xml.datatype.Duration._getXMLSchemaType30727 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getXMLSchemaType", "()Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.Duration._getYears30728 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getYears", "()I");
			global::javax.xml.datatype.Duration._getDays30729 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getDays", "()I");
			global::javax.xml.datatype.Duration._addTo30730 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "addTo", "(Ljava/util/Calendar;)V");
			global::javax.xml.datatype.Duration._addTo30731 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "addTo", "(Ljava/util/Date;)V");
			global::javax.xml.datatype.Duration._normalizeWith30732 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._isLongerThan30733 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isLongerThan", "(Ljavax/xml/datatype/Duration;)Z");
			global::javax.xml.datatype.Duration._isShorterThan30734 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isShorterThan", "(Ljavax/xml/datatype/Duration;)Z");
			global::javax.xml.datatype.Duration._Duration30735 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.Duration))]
	internal sealed partial class Duration_ : javax.xml.datatype.Duration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Duration_()
		{
			InitJNI();
		}
		internal Duration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add30736;
		public override global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._add30736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._add30736, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30737;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._hashCode30737);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._hashCode30737);
		}
		internal static global::MonoJavaBridge.MethodId _compare30738;
		public override int compare(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._compare30738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._compare30738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getField30739;
		public override global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._getField30739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._getField30739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _isSet30740;
		public override bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._isSet30740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._isSet30740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _multiply30741;
		public override global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._multiply30741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._multiply30741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _negate30742;
		public override global::javax.xml.datatype.Duration negate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._negate30742)) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._negate30742)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _getSign30743;
		public override int getSign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._getSign30743);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._getSign30743);
		}
		internal static global::MonoJavaBridge.MethodId _addTo30744;
		public override void addTo(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._addTo30744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._addTo30744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalizeWith30745;
		public override global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._normalizeWith30745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._normalizeWith30745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
			global::javax.xml.datatype.Duration_._add30736 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._hashCode30737 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.Duration_._compare30738 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "compare", "(Ljavax/xml/datatype/Duration;)I");
			global::javax.xml.datatype.Duration_._getField30739 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;");
			global::javax.xml.datatype.Duration_._isSet30740 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z");
			global::javax.xml.datatype.Duration_._multiply30741 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._negate30742 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "negate", "()Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._getSign30743 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "getSign", "()I");
			global::javax.xml.datatype.Duration_._addTo30744 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "addTo", "(Ljava/util/Calendar;)V");
			global::javax.xml.datatype.Duration_._normalizeWith30745 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;");
		}
	}
}
