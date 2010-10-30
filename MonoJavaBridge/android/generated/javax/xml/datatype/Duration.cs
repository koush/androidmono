namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass(typeof(global::javax.xml.datatype.Duration_))]
	public abstract partial class Duration : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Duration(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add30710;
		public abstract global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _equals30711;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._equals30711.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._equals30711 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._equals30711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString30712;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._toString30712.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._toString30712 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._toString30712) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30713;
		public abstract int hashCode();
		internal static global::MonoJavaBridge.MethodId _compare30714;
		public abstract int compare(javax.xml.datatype.Duration arg0);
		internal static global::MonoJavaBridge.MethodId _getField30715;
		public abstract global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0);
		internal static global::MonoJavaBridge.MethodId _isSet30716;
		public abstract bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0);
		internal static global::MonoJavaBridge.MethodId _getHours30717;
		public virtual int getHours()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getHours30717.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getHours30717 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getHours", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getHours30717);
		}
		internal static global::MonoJavaBridge.MethodId _getMinutes30718;
		public virtual int getMinutes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getMinutes30718.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getMinutes30718 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getMinutes", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getMinutes30718);
		}
		internal static global::MonoJavaBridge.MethodId _getSeconds30719;
		public virtual int getSeconds()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getSeconds30719.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getSeconds30719 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getSeconds", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getSeconds30719);
		}
		internal static global::MonoJavaBridge.MethodId _subtract30720;
		public virtual global::javax.xml.datatype.Duration subtract(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._subtract30720.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._subtract30720 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "subtract", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._subtract30720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _multiply30721;
		public virtual global::javax.xml.datatype.Duration multiply(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._multiply30721.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._multiply30721 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "multiply", "(I)Ljavax/xml/datatype/Duration;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._multiply30721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _multiply30722;
		public abstract global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0);
		internal static global::MonoJavaBridge.MethodId _negate30723;
		public abstract global::javax.xml.datatype.Duration negate();
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis30724;
		public virtual long getTimeInMillis(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getTimeInMillis30724.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getTimeInMillis30724 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Calendar;)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getTimeInMillis30724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTimeInMillis30725;
		public virtual long getTimeInMillis(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getTimeInMillis30725.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getTimeInMillis30725 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getTimeInMillis", "(Ljava/util/Date;)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getTimeInMillis30725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMonths30726;
		public virtual int getMonths()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getMonths30726.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getMonths30726 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getMonths", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getMonths30726);
		}
		internal static global::MonoJavaBridge.MethodId _getSign30727;
		public abstract int getSign();
		internal static global::MonoJavaBridge.MethodId _getXMLSchemaType30728;
		public virtual global::javax.xml.@namespace.QName getXMLSchemaType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getXMLSchemaType30728.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getXMLSchemaType30728 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getXMLSchemaType", "()Ljavax/xml/namespace/QName;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getXMLSchemaType30728) as javax.xml.@namespace.QName;
		}
		internal static global::MonoJavaBridge.MethodId _getYears30729;
		public virtual int getYears()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getYears30729.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getYears30729 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getYears", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getYears30729);
		}
		internal static global::MonoJavaBridge.MethodId _getDays30730;
		public virtual int getDays()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._getDays30730.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._getDays30730 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "getDays", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._getDays30730);
		}
		internal static global::MonoJavaBridge.MethodId _addTo30731;
		public abstract void addTo(java.util.Calendar arg0);
		internal static global::MonoJavaBridge.MethodId _addTo30732;
		public virtual void addTo(java.util.Date arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._addTo30732.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._addTo30732 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "addTo", "(Ljava/util/Date;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._addTo30732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalizeWith30733;
		public abstract global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0);
		internal static global::MonoJavaBridge.MethodId _isLongerThan30734;
		public virtual bool isLongerThan(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._isLongerThan30734.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._isLongerThan30734 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isLongerThan", "(Ljavax/xml/datatype/Duration;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._isLongerThan30734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isShorterThan30735;
		public virtual bool isShorterThan(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._isShorterThan30735.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._isShorterThan30735 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "isShorterThan", "(Ljavax/xml/datatype/Duration;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._isShorterThan30735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Duration30736;
		public Duration() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration._Duration30736.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration._Duration30736 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.Duration.staticClass, global::javax.xml.datatype.Duration._Duration30736);
			Init(@__env, handle);
		}
		static Duration()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.datatype.Duration))]
	internal sealed partial class Duration_ : javax.xml.datatype.Duration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Duration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add30737;
		public override global::javax.xml.datatype.Duration add(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._add30737.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._add30737 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "add", "(Ljavax/xml/datatype/Duration;)Ljavax/xml/datatype/Duration;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._add30737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode30738;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._hashCode30738.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._hashCode30738 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._hashCode30738);
		}
		internal static global::MonoJavaBridge.MethodId _compare30739;
		public override int compare(javax.xml.datatype.Duration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._compare30739.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._compare30739 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "compare", "(Ljavax/xml/datatype/Duration;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._compare30739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getField30740;
		public override global::java.lang.Number getField(javax.xml.datatype.DatatypeConstants.Field arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._getField30740.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._getField30740 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "getField", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Ljava/lang/Number;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._getField30740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Number;
		}
		internal static global::MonoJavaBridge.MethodId _isSet30741;
		public override bool isSet(javax.xml.datatype.DatatypeConstants.Field arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._isSet30741.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._isSet30741 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "isSet", "(Ljavax/xml/datatype/DatatypeConstants$Field;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._isSet30741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _multiply30742;
		public override global::javax.xml.datatype.Duration multiply(java.math.BigDecimal arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._multiply30742.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._multiply30742 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "multiply", "(Ljava/math/BigDecimal;)Ljavax/xml/datatype/Duration;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._multiply30742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _negate30743;
		public override global::javax.xml.datatype.Duration negate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._negate30743.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._negate30743 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "negate", "()Ljavax/xml/datatype/Duration;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._negate30743)) as javax.xml.datatype.Duration;
		}
		internal static global::MonoJavaBridge.MethodId _getSign30744;
		public override int getSign()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._getSign30744.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._getSign30744 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "getSign", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._getSign30744);
		}
		internal static global::MonoJavaBridge.MethodId _addTo30745;
		public override void addTo(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._addTo30745.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._addTo30745 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "addTo", "(Ljava/util/Calendar;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._addTo30745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _normalizeWith30746;
		public override global::javax.xml.datatype.Duration normalizeWith(java.util.Calendar arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.Duration_._normalizeWith30746.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.Duration_._normalizeWith30746 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.Duration_.staticClass, "normalizeWith", "(Ljava/util/Calendar;)Ljavax/xml/datatype/Duration;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.Duration_._normalizeWith30746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.xml.datatype.Duration;
		}
		static Duration_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.Duration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/Duration"));
		}
		internal static void InitJNI()
		{
		}
	}
}
