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
		internal static global::MonoJavaBridge.MethodId _add30591;
		public abstract global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _equals30592;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._equals30592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._equals30592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30593;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._toString30593)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._toString30593)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30594;
		public abstract int hashCode();
		internal static global::MonoJavaBridge.MethodId _compare30595;
		public abstract int compare(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _getField30596;
		public abstract global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0);
		internal static global::MonoJavaBridge.MethodId _isSet30597;
		public abstract bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0);
		internal static global::MonoJavaBridge.MethodId _getHours30598;
		public virtual int getHours() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getHours30598);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getHours30598);
		}
		internal static global::MonoJavaBridge.MethodId _getMinutes30599;
		public virtual int getMinutes() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getMinutes30599);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getMinutes30599);
		}
		internal static global::MonoJavaBridge.MethodId _getSeconds30600;
		public virtual int getSeconds() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getSeconds30600);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getSeconds30600);
		}
		internal static global::MonoJavaBridge.MethodId _subtract30601;
		public virtual global::javax.xml.datatype.Duration subtract(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._subtract30601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._subtract30601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _multiply30602;
		public virtual global::javax.xml.datatype.Duration multiply(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._multiply30602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._multiply30602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _multiply30603;
		public abstract global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0);
		internal static global::MonoJavaBridge.MethodId _negate30604;
		public abstract global::javax.xml.datatype.Duration negate();
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis30605;
		public virtual long getTimeInMillis(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getTimeInMillis30605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getTimeInMillis30605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis30606;
		public virtual long getTimeInMillis(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getTimeInMillis30606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getTimeInMillis30606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMonths30607;
		public virtual int getMonths() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getMonths30607);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getMonths30607);
		}
		internal static global::MonoJavaBridge.MethodId _getSign30608;
		public abstract int getSign();
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType30609;
		public virtual global::javax.xml.@namespace.QName getXMLSchemaType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getXMLSchemaType30609)) as javax.xml.@namespace.QName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getXMLSchemaType30609)) as javax.xml.@namespace.QName;
		}
		internal static global::MonoJavaBridge.MethodId _getYears30610;
		public virtual int getYears() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getYears30610);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getYears30610);
		}
		internal static global::MonoJavaBridge.MethodId _getDays30611;
		public virtual int getDays() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration._getDays30611);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getDays30611);
		}
		internal static global::MonoJavaBridge.MethodId _addTo30612;
		public abstract void addTo(java.util.Calendar arg0);
		internal static global::MonoJavaBridge.MethodId _addTo30613;
		public virtual void addTo(java.util.Date arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration._addTo30613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._addTo30613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalizeWith30614;
		public abstract global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0);
		internal static global::MonoJavaBridge.MethodId _isLongerThan30615;
		public virtual bool isLongerThan(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._isLongerThan30615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._isLongerThan30615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShorterThan30616;
		public virtual bool isShorterThan(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration._isShorterThan30616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._isShorterThan30616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Duration30617;
		public Duration()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._Duration30617);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
			global::javax.xml.datatype.Duration._add30591 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._equals30592 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::javax.xml.datatype.Duration._toString30593 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "toString", "()Ljava/lang/String;");
			global::javax.xml.datatype.Duration._hashCode30594 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.Duration._compare30595 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "compare", "(Ljavax/xml/datatype/Duration;)I");
			global::javax.xml.datatype.Duration._getField30596 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;");
			global::javax.xml.datatype.Duration._isSet30597 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z");
			global::javax.xml.datatype.Duration._getHours30598 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getHours", "()I");
			global::javax.xml.datatype.Duration._getMinutes30599 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getMinutes", "()I");
			global::javax.xml.datatype.Duration._getSeconds30600 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getSeconds", "()I");
			global::javax.xml.datatype.Duration._subtract30601 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "subtract", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._multiply30602 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "multiply", "(I)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._multiply30603 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._negate30604 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "negate", "()Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._getTimeInMillis30605 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Calendar;)J");
			global::javax.xml.datatype.Duration._getTimeInMillis30606 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Date;)J");
			global::javax.xml.datatype.Duration._getMonths30607 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getMonths", "()I");
			global::javax.xml.datatype.Duration._getSign30608 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getSign", "()I");
			global::javax.xml.datatype.Duration._getXMLSchemaType30609 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getXMLSchemaType", "()Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.Duration._getYears30610 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getYears", "()I");
			global::javax.xml.datatype.Duration._getDays30611 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getDays", "()I");
			global::javax.xml.datatype.Duration._addTo30612 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "addTo", "(Ljava/util/Calendar;)V");
			global::javax.xml.datatype.Duration._addTo30613 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "addTo", "(Ljava/util/Date;)V");
			global::javax.xml.datatype.Duration._normalizeWith30614 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration._isLongerThan30615 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isLongerThan", "(Ljavax/xml/datatype/Duration;)Z");
			global::javax.xml.datatype.Duration._isShorterThan30616 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isShorterThan", "(Ljavax/xml/datatype/Duration;)Z");
			global::javax.xml.datatype.Duration._Duration30617 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _add30618;
		public override global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._add30618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._add30618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30619;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._hashCode30619);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._hashCode30619);
		}
		internal static global::MonoJavaBridge.MethodId _compare30620;
		public override int compare(javax.xml.datatype.Duration arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._compare30620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._compare30620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getField30621;
		public override global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._getField30621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._getField30621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _isSet30622;
		public override bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._isSet30622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._isSet30622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _multiply30623;
		public override global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._multiply30623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._multiply30623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _negate30624;
		public override global::javax.xml.datatype.Duration negate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._negate30624)) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._negate30624)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _getSign30625;
		public override int getSign() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._getSign30625);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._getSign30625);
		}
		internal static global::MonoJavaBridge.MethodId _addTo30626;
		public override void addTo(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._addTo30626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._addTo30626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalizeWith30627;
		public override global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._normalizeWith30627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_.staticClass, global::javax.xml.datatype.Duration_._normalizeWith30627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
			global::javax.xml.datatype.Duration_._add30618 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._hashCode30619 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "hashCode", "()I");
			global::javax.xml.datatype.Duration_._compare30620 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "compare", "(Ljavax/xml/datatype/Duration;)I");
			global::javax.xml.datatype.Duration_._getField30621 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;");
			global::javax.xml.datatype.Duration_._isSet30622 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z");
			global::javax.xml.datatype.Duration_._multiply30623 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._negate30624 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "negate", "()Ljavax/xml/datatype/Duration;");
			global::javax.xml.datatype.Duration_._getSign30625 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "getSign", "()I");
			global::javax.xml.datatype.Duration_._addTo30626 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "addTo", "(Ljava/util/Calendar;)V");
			global::javax.xml.datatype.Duration_._normalizeWith30627 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;");
		}
	}
}
