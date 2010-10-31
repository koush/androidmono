namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Address : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Address(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "toString", "()Ljava/lang/String;", ref global::android.location.Address._m0) as java.lang.String;
		}
		public new global::java.lang.String Locality
		{
			get
			{
				return getLocality();
			}
			set
			{
				setLocality(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getLocality()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getLocality", "()Ljava/lang/String;", ref global::android.location.Address._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.location.Address._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Address.staticClass, "describeContents", "()I", ref global::android.location.Address._m3);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
			set
			{
				setExtras(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.os.Bundle getExtras()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.location.Address.staticClass, "getExtras", "()Landroid/os/Bundle;", ref global::android.location.Address._m4) as android.os.Bundle;
		}
		public new global::java.util.Locale Locale
		{
			get
			{
				return getLocale();
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.util.Locale getLocale()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.util.Locale>(this, global::android.location.Address.staticClass, "getLocale", "()Ljava/util/Locale;", ref global::android.location.Address._m5) as java.util.Locale;
		}
		public new int MaxAddressLineIndex
		{
			get
			{
				return getMaxAddressLineIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getMaxAddressLineIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.location.Address.staticClass, "getMaxAddressLineIndex", "()I", ref global::android.location.Address._m6);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getAddressLine(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getAddressLine", "(I)Ljava/lang/String;", ref global::android.location.Address._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setAddressLine(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setAddressLine", "(ILjava/lang/String;)V", ref global::android.location.Address._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String FeatureName
		{
			get
			{
				return getFeatureName();
			}
			set
			{
				setFeatureName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.String getFeatureName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getFeatureName", "()Ljava/lang/String;", ref global::android.location.Address._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setFeatureName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setFeatureName", "(Ljava/lang/String;)V", ref global::android.location.Address._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String AdminArea
		{
			get
			{
				return getAdminArea();
			}
			set
			{
				setAdminArea(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getAdminArea()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getAdminArea", "()Ljava/lang/String;", ref global::android.location.Address._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setAdminArea(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setAdminArea", "(Ljava/lang/String;)V", ref global::android.location.Address._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubAdminArea
		{
			get
			{
				return getSubAdminArea();
			}
			set
			{
				setSubAdminArea(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getSubAdminArea()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getSubAdminArea", "()Ljava/lang/String;", ref global::android.location.Address._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setSubAdminArea(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setSubAdminArea", "(Ljava/lang/String;)V", ref global::android.location.Address._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setLocality(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setLocality", "(Ljava/lang/String;)V", ref global::android.location.Address._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubLocality
		{
			get
			{
				return getSubLocality();
			}
			set
			{
				setSubLocality(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual global::java.lang.String getSubLocality()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getSubLocality", "()Ljava/lang/String;", ref global::android.location.Address._m16) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setSubLocality(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setSubLocality", "(Ljava/lang/String;)V", ref global::android.location.Address._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Thoroughfare
		{
			get
			{
				return getThoroughfare();
			}
			set
			{
				setThoroughfare(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual global::java.lang.String getThoroughfare()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getThoroughfare", "()Ljava/lang/String;", ref global::android.location.Address._m18) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setThoroughfare(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setThoroughfare", "(Ljava/lang/String;)V", ref global::android.location.Address._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String SubThoroughfare
		{
			get
			{
				return getSubThoroughfare();
			}
			set
			{
				setSubThoroughfare(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual global::java.lang.String getSubThoroughfare()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getSubThoroughfare", "()Ljava/lang/String;", ref global::android.location.Address._m20) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setSubThoroughfare(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setSubThoroughfare", "(Ljava/lang/String;)V", ref global::android.location.Address._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Premises
		{
			get
			{
				return getPremises();
			}
			set
			{
				setPremises(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::java.lang.String getPremises()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getPremises", "()Ljava/lang/String;", ref global::android.location.Address._m22) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setPremises(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setPremises", "(Ljava/lang/String;)V", ref global::android.location.Address._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String PostalCode
		{
			get
			{
				return getPostalCode();
			}
			set
			{
				setPostalCode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual global::java.lang.String getPostalCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getPostalCode", "()Ljava/lang/String;", ref global::android.location.Address._m24) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setPostalCode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setPostalCode", "(Ljava/lang/String;)V", ref global::android.location.Address._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CountryCode
		{
			get
			{
				return getCountryCode();
			}
			set
			{
				setCountryCode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::java.lang.String getCountryCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getCountryCode", "()Ljava/lang/String;", ref global::android.location.Address._m26) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setCountryCode(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setCountryCode", "(Ljava/lang/String;)V", ref global::android.location.Address._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String CountryName
		{
			get
			{
				return getCountryName();
			}
			set
			{
				setCountryName(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::java.lang.String getCountryName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getCountryName", "()Ljava/lang/String;", ref global::android.location.Address._m28) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual void setCountryName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setCountryName", "(Ljava/lang/String;)V", ref global::android.location.Address._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool hasLatitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Address.staticClass, "hasLatitude", "()Z", ref global::android.location.Address._m30);
		}
		public new double Latitude
		{
			get
			{
				return getLatitude();
			}
			set
			{
				setLatitude(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual double getLatitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.location.Address.staticClass, "getLatitude", "()D", ref global::android.location.Address._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setLatitude(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setLatitude", "(D)V", ref global::android.location.Address._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual void clearLatitude()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "clearLatitude", "()V", ref global::android.location.Address._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool hasLongitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.location.Address.staticClass, "hasLongitude", "()Z", ref global::android.location.Address._m34);
		}
		public new double Longitude
		{
			get
			{
				return getLongitude();
			}
			set
			{
				setLongitude(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual double getLongitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.location.Address.staticClass, "getLongitude", "()D", ref global::android.location.Address._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setLongitude(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setLongitude", "(D)V", ref global::android.location.Address._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void clearLongitude()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "clearLongitude", "()V", ref global::android.location.Address._m37);
		}
		public new global::java.lang.String Phone
		{
			get
			{
				return getPhone();
			}
			set
			{
				setPhone(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::java.lang.String getPhone()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getPhone", "()Ljava/lang/String;", ref global::android.location.Address._m38) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void setPhone(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setPhone", "(Ljava/lang/String;)V", ref global::android.location.Address._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Url
		{
			get
			{
				return getUrl();
			}
			set
			{
				setUrl(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.lang.String getUrl()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.location.Address.staticClass, "getUrl", "()Ljava/lang/String;", ref global::android.location.Address._m40) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void setUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setUrl", "(Ljava/lang/String;)V", ref global::android.location.Address._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void setExtras(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.location.Address.staticClass, "setExtras", "(Landroid/os/Bundle;)V", ref global::android.location.Address._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public Address(java.util.Locale arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.location.Address._m43.native == global::System.IntPtr.Zero)
				global::android.location.Address._m43 = @__env.GetMethodIDNoThrow(global::android.location.Address.staticClass, "<init>", "(Ljava/util/Locale;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.location.Address.staticClass, global::android.location.Address._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2597;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.location.Address.staticClass, _CREATOR2597)) as android.os.Parcelable_Creator;
			}
		}
		static Address()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.Address.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/Address"));
			global::android.location.Address._CREATOR2597 = @__env.GetStaticFieldIDNoThrow(global::android.location.Address.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
