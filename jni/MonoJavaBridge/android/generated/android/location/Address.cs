namespace android.location
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Address : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Address()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.location.Address), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.location.Address(@__env);
			}
		}
		protected Address(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString4427;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._toString4427));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._toString4427));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocality4428;
		public virtual global::java.lang.String getLocality() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getLocality4428));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getLocality4428));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4429;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._writeToParcel4429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._writeToParcel4429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4430;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.Address._describeContents4430);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Address.staticClass, global::android.location.Address._describeContents4430);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtras4431;
		public virtual global::android.os.Bundle getExtras() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getExtras4431));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getExtras4431));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLocale4432;
		public virtual global::java.util.Locale getLocale() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getLocale4432));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getLocale4432));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAddressLineIndex4433;
		public virtual int getMaxAddressLineIndex() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.location.Address._getMaxAddressLineIndex4433);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.location.Address.staticClass, global::android.location.Address._getMaxAddressLineIndex4433);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAddressLine4434;
		public virtual global::java.lang.String getAddressLine(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getAddressLine4434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getAddressLine4434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAddressLine4435;
		public virtual void setAddressLine(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setAddressLine4435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setAddressLine4435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFeatureName4436;
		public virtual global::java.lang.String getFeatureName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getFeatureName4436));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getFeatureName4436));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFeatureName4437;
		public virtual void setFeatureName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setFeatureName4437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setFeatureName4437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAdminArea4438;
		public virtual global::java.lang.String getAdminArea() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getAdminArea4438));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getAdminArea4438));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAdminArea4439;
		public virtual void setAdminArea(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setAdminArea4439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setAdminArea4439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubAdminArea4440;
		public virtual global::java.lang.String getSubAdminArea() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getSubAdminArea4440));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getSubAdminArea4440));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSubAdminArea4441;
		public virtual void setSubAdminArea(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setSubAdminArea4441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setSubAdminArea4441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLocality4442;
		public virtual void setLocality(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setLocality4442, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setLocality4442, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubLocality4443;
		public virtual global::java.lang.String getSubLocality() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getSubLocality4443));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getSubLocality4443));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSubLocality4444;
		public virtual void setSubLocality(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setSubLocality4444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setSubLocality4444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getThoroughfare4445;
		public virtual global::java.lang.String getThoroughfare() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getThoroughfare4445));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getThoroughfare4445));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setThoroughfare4446;
		public virtual void setThoroughfare(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setThoroughfare4446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setThoroughfare4446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSubThoroughfare4447;
		public virtual global::java.lang.String getSubThoroughfare() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getSubThoroughfare4447));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getSubThoroughfare4447));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSubThoroughfare4448;
		public virtual void setSubThoroughfare(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setSubThoroughfare4448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setSubThoroughfare4448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPremises4449;
		public virtual global::java.lang.String getPremises() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getPremises4449));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getPremises4449));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPremises4450;
		public virtual void setPremises(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setPremises4450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setPremises4450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPostalCode4451;
		public virtual global::java.lang.String getPostalCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getPostalCode4451));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getPostalCode4451));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPostalCode4452;
		public virtual void setPostalCode(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setPostalCode4452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setPostalCode4452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCountryCode4453;
		public virtual global::java.lang.String getCountryCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getCountryCode4453));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getCountryCode4453));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCountryCode4454;
		public virtual void setCountryCode(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setCountryCode4454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setCountryCode4454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCountryName4455;
		public virtual global::java.lang.String getCountryName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getCountryName4455));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getCountryName4455));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCountryName4456;
		public virtual void setCountryName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setCountryName4456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setCountryName4456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasLatitude4457;
		public virtual bool hasLatitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Address._hasLatitude4457);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Address.staticClass, global::android.location.Address._hasLatitude4457);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLatitude4458;
		public virtual double getLatitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.location.Address._getLatitude4458);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Address.staticClass, global::android.location.Address._getLatitude4458);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLatitude4459;
		public virtual void setLatitude(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setLatitude4459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setLatitude4459, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearLatitude4460;
		public virtual void clearLatitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._clearLatitude4460);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._clearLatitude4460);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasLongitude4461;
		public virtual bool hasLongitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.location.Address._hasLongitude4461);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.location.Address.staticClass, global::android.location.Address._hasLongitude4461);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLongitude4462;
		public virtual double getLongitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.location.Address._getLongitude4462);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.location.Address.staticClass, global::android.location.Address._getLongitude4462);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLongitude4463;
		public virtual void setLongitude(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setLongitude4463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setLongitude4463, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clearLongitude4464;
		public virtual void clearLongitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._clearLongitude4464);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._clearLongitude4464);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPhone4465;
		public virtual global::java.lang.String getPhone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getPhone4465));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getPhone4465));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPhone4466;
		public virtual void setPhone(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setPhone4466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setPhone4466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getUrl4467;
		public virtual global::java.lang.String getUrl() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.location.Address._getUrl4467));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.location.Address.staticClass, global::android.location.Address._getUrl4467));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setUrl4468;
		public virtual void setUrl(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setUrl4468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setUrl4468, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setExtras4469;
		public virtual void setExtras(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.location.Address._setExtras4469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.location.Address.staticClass, global::android.location.Address._setExtras4469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Address4470;
		public Address(java.util.Locale arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.location.Address.staticClass, global::android.location.Address._Address4470, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR4471;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.location.Address.staticClass = @__class;
			global::android.location.Address._toString4427 = @__env.GetMethodID(global::android.location.Address.staticClass, "toString", "()Ljava/lang/String;");
			global::android.location.Address._getLocality4428 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLocality", "()Ljava/lang/String;");
			global::android.location.Address._writeToParcel4429 = @__env.GetMethodID(global::android.location.Address.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.location.Address._describeContents4430 = @__env.GetMethodID(global::android.location.Address.staticClass, "describeContents", "()I");
			global::android.location.Address._getExtras4431 = @__env.GetMethodID(global::android.location.Address.staticClass, "getExtras", "()Landroid/os/Bundle;");
			global::android.location.Address._getLocale4432 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLocale", "()Ljava/util/Locale;");
			global::android.location.Address._getMaxAddressLineIndex4433 = @__env.GetMethodID(global::android.location.Address.staticClass, "getMaxAddressLineIndex", "()I");
			global::android.location.Address._getAddressLine4434 = @__env.GetMethodID(global::android.location.Address.staticClass, "getAddressLine", "(I)Ljava/lang/String;");
			global::android.location.Address._setAddressLine4435 = @__env.GetMethodID(global::android.location.Address.staticClass, "setAddressLine", "(ILjava/lang/String;)V");
			global::android.location.Address._getFeatureName4436 = @__env.GetMethodID(global::android.location.Address.staticClass, "getFeatureName", "()Ljava/lang/String;");
			global::android.location.Address._setFeatureName4437 = @__env.GetMethodID(global::android.location.Address.staticClass, "setFeatureName", "(Ljava/lang/String;)V");
			global::android.location.Address._getAdminArea4438 = @__env.GetMethodID(global::android.location.Address.staticClass, "getAdminArea", "()Ljava/lang/String;");
			global::android.location.Address._setAdminArea4439 = @__env.GetMethodID(global::android.location.Address.staticClass, "setAdminArea", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubAdminArea4440 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubAdminArea", "()Ljava/lang/String;");
			global::android.location.Address._setSubAdminArea4441 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubAdminArea", "(Ljava/lang/String;)V");
			global::android.location.Address._setLocality4442 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLocality", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubLocality4443 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubLocality", "()Ljava/lang/String;");
			global::android.location.Address._setSubLocality4444 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubLocality", "(Ljava/lang/String;)V");
			global::android.location.Address._getThoroughfare4445 = @__env.GetMethodID(global::android.location.Address.staticClass, "getThoroughfare", "()Ljava/lang/String;");
			global::android.location.Address._setThoroughfare4446 = @__env.GetMethodID(global::android.location.Address.staticClass, "setThoroughfare", "(Ljava/lang/String;)V");
			global::android.location.Address._getSubThoroughfare4447 = @__env.GetMethodID(global::android.location.Address.staticClass, "getSubThoroughfare", "()Ljava/lang/String;");
			global::android.location.Address._setSubThoroughfare4448 = @__env.GetMethodID(global::android.location.Address.staticClass, "setSubThoroughfare", "(Ljava/lang/String;)V");
			global::android.location.Address._getPremises4449 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPremises", "()Ljava/lang/String;");
			global::android.location.Address._setPremises4450 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPremises", "(Ljava/lang/String;)V");
			global::android.location.Address._getPostalCode4451 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPostalCode", "()Ljava/lang/String;");
			global::android.location.Address._setPostalCode4452 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPostalCode", "(Ljava/lang/String;)V");
			global::android.location.Address._getCountryCode4453 = @__env.GetMethodID(global::android.location.Address.staticClass, "getCountryCode", "()Ljava/lang/String;");
			global::android.location.Address._setCountryCode4454 = @__env.GetMethodID(global::android.location.Address.staticClass, "setCountryCode", "(Ljava/lang/String;)V");
			global::android.location.Address._getCountryName4455 = @__env.GetMethodID(global::android.location.Address.staticClass, "getCountryName", "()Ljava/lang/String;");
			global::android.location.Address._setCountryName4456 = @__env.GetMethodID(global::android.location.Address.staticClass, "setCountryName", "(Ljava/lang/String;)V");
			global::android.location.Address._hasLatitude4457 = @__env.GetMethodID(global::android.location.Address.staticClass, "hasLatitude", "()Z");
			global::android.location.Address._getLatitude4458 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLatitude", "()D");
			global::android.location.Address._setLatitude4459 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLatitude", "(D)V");
			global::android.location.Address._clearLatitude4460 = @__env.GetMethodID(global::android.location.Address.staticClass, "clearLatitude", "()V");
			global::android.location.Address._hasLongitude4461 = @__env.GetMethodID(global::android.location.Address.staticClass, "hasLongitude", "()Z");
			global::android.location.Address._getLongitude4462 = @__env.GetMethodID(global::android.location.Address.staticClass, "getLongitude", "()D");
			global::android.location.Address._setLongitude4463 = @__env.GetMethodID(global::android.location.Address.staticClass, "setLongitude", "(D)V");
			global::android.location.Address._clearLongitude4464 = @__env.GetMethodID(global::android.location.Address.staticClass, "clearLongitude", "()V");
			global::android.location.Address._getPhone4465 = @__env.GetMethodID(global::android.location.Address.staticClass, "getPhone", "()Ljava/lang/String;");
			global::android.location.Address._setPhone4466 = @__env.GetMethodID(global::android.location.Address.staticClass, "setPhone", "(Ljava/lang/String;)V");
			global::android.location.Address._getUrl4467 = @__env.GetMethodID(global::android.location.Address.staticClass, "getUrl", "()Ljava/lang/String;");
			global::android.location.Address._setUrl4468 = @__env.GetMethodID(global::android.location.Address.staticClass, "setUrl", "(Ljava/lang/String;)V");
			global::android.location.Address._setExtras4469 = @__env.GetMethodID(global::android.location.Address.staticClass, "setExtras", "(Landroid/os/Bundle;)V");
			global::android.location.Address._Address4470 = @__env.GetMethodID(global::android.location.Address.staticClass, "<init>", "(Ljava/util/Locale;)V");
		}
	}
}
