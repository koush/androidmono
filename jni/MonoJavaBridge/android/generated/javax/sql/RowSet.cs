namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSet_))]
	public interface RowSet : java.sql.ResultSet
	{
		void setReadOnly(bool arg0);
		void setBoolean(java.lang.String arg0, bool arg1);
		void setBoolean(int arg0, bool arg1);
		void setByte(java.lang.String arg0, byte arg1);
		void setByte(int arg0, byte arg1);
		void setShort(int arg0, short arg1);
		void setShort(java.lang.String arg0, short arg1);
		void setInt(java.lang.String arg0, int arg1);
		void setInt(int arg0, int arg1);
		void setLong(int arg0, long arg1);
		void setLong(java.lang.String arg0, long arg1);
		void setFloat(java.lang.String arg0, float arg1);
		void setFloat(int arg0, float arg1);
		void setDouble(int arg0, double arg1);
		void setDouble(java.lang.String arg0, double arg1);
		bool isReadOnly();
		void setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setTimestamp(int arg0, java.sql.Timestamp arg1);
		void setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1);
		void setURL(int arg0, java.net.URL arg1);
		void setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2);
		void setTime(java.lang.String arg0, java.sql.Time arg1);
		void setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2);
		void setTime(int arg0, java.sql.Time arg1);
		void setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2);
		void setDate(int arg0, java.sql.Date arg1);
		void setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2);
		void setDate(java.lang.String arg0, java.sql.Date arg1);
		void execute();
		void setPassword(java.lang.String arg0);
		void setType(int arg0);
		global::java.lang.String getPassword();
		void setString(int arg0, java.lang.String arg1);
		void setString(java.lang.String arg0, java.lang.String arg1);
		void setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3);
		void setObject(int arg0, java.lang.Object arg1, int arg2, int arg3);
		void setObject(int arg0, java.lang.Object arg1, int arg2);
		void setObject(java.lang.String arg0, java.lang.Object arg1, int arg2);
		void setObject(java.lang.String arg0, java.lang.Object arg1);
		void setObject(int arg0, java.lang.Object arg1);
		global::java.lang.String getUrl();
		void setUrl(java.lang.String arg0);
		void setBytes(java.lang.String arg0, byte[] arg1);
		void setBytes(int arg0, byte[] arg1);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(java.lang.String arg0, java.io.InputStream arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1);
		void setNull(java.lang.String arg0, int arg1, java.lang.String arg2);
		void setNull(int arg0, int arg1, java.lang.String arg2);
		void setNull(int arg0, int arg1);
		void setNull(java.lang.String arg0, int arg1);
		void setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1);
		void setBigDecimal(int arg0, java.math.BigDecimal arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(int arg0, java.io.InputStream arg1);
		void setAsciiStream(java.lang.String arg0, java.io.InputStream arg1);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2);
		void setCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void setCharacterStream(int arg0, java.io.Reader arg1);
		void setCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void setNString(java.lang.String arg0, java.lang.String arg1);
		void setNString(int arg0, java.lang.String arg1);
		void setNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setNCharacterStream(int arg0, java.io.Reader arg1);
		void setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setNCharacterStream(java.lang.String arg0, java.io.Reader arg1);
		void setNClob(java.lang.String arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1);
		void setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setNClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(java.lang.String arg0, java.io.Reader arg1, long arg2);
		void setClob(java.lang.String arg0, java.sql.Clob arg1);
		void setClob(java.lang.String arg0, java.io.Reader arg1);
		void setClob(int arg0, java.sql.Clob arg1);
		void setClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.io.Reader arg1);
		void setBlob(int arg0, java.io.InputStream arg1);
		void setBlob(java.lang.String arg0, java.sql.Blob arg1);
		void setBlob(java.lang.String arg0, java.io.InputStream arg1);
		void setBlob(int arg0, java.sql.Blob arg1);
		void setBlob(int arg0, java.io.InputStream arg1, long arg2);
		void setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2);
		void clearParameters();
		void setRef(int arg0, java.sql.Ref arg1);
		void setArray(int arg0, java.sql.Array arg1);
		int getMaxFieldSize();
		void setMaxFieldSize(int arg0);
		int getMaxRows();
		void setMaxRows(int arg0);
		void setEscapeProcessing(bool arg0);
		int getQueryTimeout();
		void setQueryTimeout(int arg0);
		void setTransactionIsolation(int arg0);
		int getTransactionIsolation();
		global::java.util.Map getTypeMap();
		void setTypeMap(java.util.Map arg0);
		global::java.lang.String getDataSourceName();
		void setDataSourceName(java.lang.String arg0);
		global::java.lang.String getUsername();
		void setUsername(java.lang.String arg0);
		global::java.lang.String getCommand();
		void setCommand(java.lang.String arg0);
		bool getEscapeProcessing();
		void setConcurrency(int arg0);
		void addRowSetListener(javax.sql.RowSetListener arg0);
		void removeRowSetListener(javax.sql.RowSetListener arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.sql.RowSet))]
	public sealed partial class RowSet_ : java.lang.Object, RowSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RowSet_()
		{
			InitJNI();
		}
		internal RowSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setReadOnly23737;
		 void javax.sql.RowSet.setReadOnly(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setReadOnly23737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setReadOnly23737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean23738;
		 void javax.sql.RowSet.setBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBoolean23738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBoolean23738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean23739;
		 void javax.sql.RowSet.setBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBoolean23739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBoolean23739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte23740;
		 void javax.sql.RowSet.setByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setByte23740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setByte23740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte23741;
		 void javax.sql.RowSet.setByte(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setByte23741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setByte23741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort23742;
		 void javax.sql.RowSet.setShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setShort23742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setShort23742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort23743;
		 void javax.sql.RowSet.setShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setShort23743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setShort23743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt23744;
		 void javax.sql.RowSet.setInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setInt23744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setInt23744, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt23745;
		 void javax.sql.RowSet.setInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setInt23745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setInt23745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong23746;
		 void javax.sql.RowSet.setLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setLong23746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setLong23746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong23747;
		 void javax.sql.RowSet.setLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setLong23747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setLong23747, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat23748;
		 void javax.sql.RowSet.setFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setFloat23748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setFloat23748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat23749;
		 void javax.sql.RowSet.setFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setFloat23749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setFloat23749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble23750;
		 void javax.sql.RowSet.setDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDouble23750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDouble23750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble23751;
		 void javax.sql.RowSet.setDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDouble23751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDouble23751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly23752;
		 bool javax.sql.RowSet.isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isReadOnly23752);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isReadOnly23752);
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp23753;
		 void javax.sql.RowSet.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTimestamp23753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTimestamp23753, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp23754;
		 void javax.sql.RowSet.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTimestamp23754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTimestamp23754, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp23755;
		 void javax.sql.RowSet.setTimestamp(int arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTimestamp23755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTimestamp23755, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp23756;
		 void javax.sql.RowSet.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTimestamp23756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTimestamp23756, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setURL23757;
		 void javax.sql.RowSet.setURL(int arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setURL23757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setURL23757, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime23758;
		 void javax.sql.RowSet.setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTime23758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTime23758, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime23759;
		 void javax.sql.RowSet.setTime(java.lang.String arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTime23759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTime23759, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime23760;
		 void javax.sql.RowSet.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTime23760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTime23760, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime23761;
		 void javax.sql.RowSet.setTime(int arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTime23761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTime23761, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate23762;
		 void javax.sql.RowSet.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDate23762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDate23762, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate23763;
		 void javax.sql.RowSet.setDate(int arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDate23763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDate23763, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate23764;
		 void javax.sql.RowSet.setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDate23764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDate23764, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate23765;
		 void javax.sql.RowSet.setDate(java.lang.String arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDate23765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDate23765, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute23766;
		 void javax.sql.RowSet.execute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._execute23766);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._execute23766);
		}
		internal static global::MonoJavaBridge.MethodId _setPassword23767;
		 void javax.sql.RowSet.setPassword(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setPassword23767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setPassword23767, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setType23768;
		 void javax.sql.RowSet.setType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setType23768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setType23768, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getPassword23769;
		 global::java.lang.String javax.sql.RowSet.getPassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getPassword23769)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getPassword23769)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setString23770;
		 void javax.sql.RowSet.setString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setString23770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setString23770, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setString23771;
		 void javax.sql.RowSet.setString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setString23771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setString23771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject23772;
		 void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject23772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject23772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject23773;
		 void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject23773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject23773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject23774;
		 void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject23774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject23774, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject23775;
		 void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject23775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject23775, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject23776;
		 void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject23776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject23776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject23777;
		 void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setObject23777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setObject23777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getUrl23778;
		 global::java.lang.String javax.sql.RowSet.getUrl() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getUrl23778)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getUrl23778)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUrl23779;
		 void javax.sql.RowSet.setUrl(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setUrl23779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setUrl23779, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBytes23780;
		 void javax.sql.RowSet.setBytes(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBytes23780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBytes23780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBytes23781;
		 void javax.sql.RowSet.setBytes(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBytes23781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBytes23781, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream23782;
		 void javax.sql.RowSet.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBinaryStream23782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBinaryStream23782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream23783;
		 void javax.sql.RowSet.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBinaryStream23783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBinaryStream23783, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream23784;
		 void javax.sql.RowSet.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBinaryStream23784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBinaryStream23784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream23785;
		 void javax.sql.RowSet.setBinaryStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBinaryStream23785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBinaryStream23785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNull23786;
		 void javax.sql.RowSet.setNull(java.lang.String arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNull23786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNull23786, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull23787;
		 void javax.sql.RowSet.setNull(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNull23787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNull23787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull23788;
		 void javax.sql.RowSet.setNull(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNull23788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNull23788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNull23789;
		 void javax.sql.RowSet.setNull(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNull23789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNull23789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal23790;
		 void javax.sql.RowSet.setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBigDecimal23790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBigDecimal23790, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal23791;
		 void javax.sql.RowSet.setBigDecimal(int arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBigDecimal23791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBigDecimal23791, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream23792;
		 void javax.sql.RowSet.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setAsciiStream23792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setAsciiStream23792, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream23793;
		 void javax.sql.RowSet.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setAsciiStream23793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setAsciiStream23793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream23794;
		 void javax.sql.RowSet.setAsciiStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setAsciiStream23794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setAsciiStream23794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream23795;
		 void javax.sql.RowSet.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setAsciiStream23795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setAsciiStream23795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream23796;
		 void javax.sql.RowSet.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCharacterStream23796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCharacterStream23796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream23797;
		 void javax.sql.RowSet.setCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCharacterStream23797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCharacterStream23797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream23798;
		 void javax.sql.RowSet.setCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCharacterStream23798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCharacterStream23798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream23799;
		 void javax.sql.RowSet.setCharacterStream(int arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCharacterStream23799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCharacterStream23799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNString23800;
		 void javax.sql.RowSet.setNString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNString23800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNString23800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNString23801;
		 void javax.sql.RowSet.setNString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNString23801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNString23801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream23802;
		 void javax.sql.RowSet.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNCharacterStream23802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNCharacterStream23802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream23803;
		 void javax.sql.RowSet.setNCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNCharacterStream23803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNCharacterStream23803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream23804;
		 void javax.sql.RowSet.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNCharacterStream23804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNCharacterStream23804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream23805;
		 void javax.sql.RowSet.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNCharacterStream23805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNCharacterStream23805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob23806;
		 void javax.sql.RowSet.setNClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNClob23806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNClob23806, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob23807;
		 void javax.sql.RowSet.setNClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNClob23807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNClob23807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob23808;
		 void javax.sql.RowSet.setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNClob23808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNClob23808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob23809;
		 void javax.sql.RowSet.setNClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setNClob23809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setNClob23809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob23810;
		 void javax.sql.RowSet.setClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob23810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob23810, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob23811;
		 void javax.sql.RowSet.setClob(java.lang.String arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob23811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob23811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob23812;
		 void javax.sql.RowSet.setClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob23812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob23812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob23813;
		 void javax.sql.RowSet.setClob(int arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob23813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob23813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob23814;
		 void javax.sql.RowSet.setClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob23814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob23814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob23815;
		 void javax.sql.RowSet.setClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setClob23815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setClob23815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob23816;
		 void javax.sql.RowSet.setBlob(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob23816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob23816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob23817;
		 void javax.sql.RowSet.setBlob(java.lang.String arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob23817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob23817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob23818;
		 void javax.sql.RowSet.setBlob(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob23818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob23818, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob23819;
		 void javax.sql.RowSet.setBlob(int arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob23819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob23819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob23820;
		 void javax.sql.RowSet.setBlob(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob23820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob23820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob23821;
		 void javax.sql.RowSet.setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setBlob23821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setBlob23821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters23822;
		 void javax.sql.RowSet.clearParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._clearParameters23822);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._clearParameters23822);
		}
		internal static global::MonoJavaBridge.MethodId _setRef23823;
		 void javax.sql.RowSet.setRef(int arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setRef23823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setRef23823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setArray23824;
		 void javax.sql.RowSet.setArray(int arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setArray23824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setArray23824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize23825;
		 int javax.sql.RowSet.getMaxFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getMaxFieldSize23825);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getMaxFieldSize23825);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize23826;
		 void javax.sql.RowSet.setMaxFieldSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setMaxFieldSize23826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setMaxFieldSize23826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows23827;
		 int javax.sql.RowSet.getMaxRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getMaxRows23827);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getMaxRows23827);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows23828;
		 void javax.sql.RowSet.setMaxRows(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setMaxRows23828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setMaxRows23828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing23829;
		 void javax.sql.RowSet.setEscapeProcessing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setEscapeProcessing23829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setEscapeProcessing23829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout23830;
		 int javax.sql.RowSet.getQueryTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getQueryTimeout23830);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getQueryTimeout23830);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout23831;
		 void javax.sql.RowSet.setQueryTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setQueryTimeout23831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setQueryTimeout23831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setTransactionIsolation23832;
		 void javax.sql.RowSet.setTransactionIsolation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTransactionIsolation23832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTransactionIsolation23832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getTransactionIsolation23833;
		 int javax.sql.RowSet.getTransactionIsolation() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getTransactionIsolation23833);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTransactionIsolation23833);
		}
		internal static global::MonoJavaBridge.MethodId _getTypeMap23834;
		 global::java.util.Map javax.sql.RowSet.getTypeMap() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTypeMap23834)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTypeMap23834)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _setTypeMap23835;
		 void javax.sql.RowSet.setTypeMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setTypeMap23835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setTypeMap23835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDataSourceName23836;
		 global::java.lang.String javax.sql.RowSet.getDataSourceName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDataSourceName23836)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDataSourceName23836)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setDataSourceName23837;
		 void javax.sql.RowSet.setDataSourceName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setDataSourceName23837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setDataSourceName23837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUsername23838;
		 global::java.lang.String javax.sql.RowSet.getUsername() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getUsername23838)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getUsername23838)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setUsername23839;
		 void javax.sql.RowSet.setUsername(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setUsername23839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setUsername23839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCommand23840;
		 global::java.lang.String javax.sql.RowSet.getCommand() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getCommand23840)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getCommand23840)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setCommand23841;
		 void javax.sql.RowSet.setCommand(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setCommand23841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setCommand23841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEscapeProcessing23842;
		 bool javax.sql.RowSet.getEscapeProcessing() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._getEscapeProcessing23842);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getEscapeProcessing23842);
		}
		internal static global::MonoJavaBridge.MethodId _setConcurrency23843;
		 void javax.sql.RowSet.setConcurrency(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setConcurrency23843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setConcurrency23843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addRowSetListener23844;
		 void javax.sql.RowSet.addRowSetListener(javax.sql.RowSetListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._addRowSetListener23844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._addRowSetListener23844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeRowSetListener23845;
		 void javax.sql.RowSet.removeRowSetListener(javax.sql.RowSetListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._removeRowSetListener23845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._removeRowSetListener23845, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getObject23846;
		 global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getObject23846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getObject23846, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject23847;
		 global::java.lang.Object java.sql.ResultSet.getObject(int arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getObject23847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getObject23847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject23848;
		 global::java.lang.Object java.sql.ResultSet.getObject(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getObject23848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getObject23848, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getObject23849;
		 global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0, java.util.Map arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getObject23849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getObject23849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean23850;
		 bool java.sql.ResultSet.getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._getBoolean23850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBoolean23850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean23851;
		 bool java.sql.ResultSet.getBoolean(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._getBoolean23851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBoolean23851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte23852;
		 byte java.sql.ResultSet.getByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::javax.sql.RowSet_._getByte23852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getByte23852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte23853;
		 byte java.sql.ResultSet.getByte(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::javax.sql.RowSet_._getByte23853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getByte23853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort23854;
		 short java.sql.ResultSet.getShort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::javax.sql.RowSet_._getShort23854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getShort23854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort23855;
		 short java.sql.ResultSet.getShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::javax.sql.RowSet_._getShort23855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getShort23855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt23856;
		 int java.sql.ResultSet.getInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getInt23856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getInt23856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt23857;
		 int java.sql.ResultSet.getInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getInt23857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getInt23857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong23858;
		 long java.sql.ResultSet.getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.sql.RowSet_._getLong23858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getLong23858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong23859;
		 long java.sql.ResultSet.getLong(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::javax.sql.RowSet_._getLong23859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getLong23859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat23860;
		 float java.sql.ResultSet.getFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::javax.sql.RowSet_._getFloat23860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getFloat23860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat23861;
		 float java.sql.ResultSet.getFloat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::javax.sql.RowSet_._getFloat23861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getFloat23861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble23862;
		 double java.sql.ResultSet.getDouble(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::javax.sql.RowSet_._getDouble23862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDouble23862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble23863;
		 double java.sql.ResultSet.getDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::javax.sql.RowSet_._getDouble23863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDouble23863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBytes23864;
		 byte[] java.sql.ResultSet.getBytes(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBytes23864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBytes23864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getBytes23865;
		 byte[] java.sql.ResultSet.getBytes(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBytes23865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBytes23865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getArray23866;
		 global::java.sql.Array java.sql.ResultSet.getArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getArray23866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getArray23866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _getArray23867;
		 global::java.sql.Array java.sql.ResultSet.getArray(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getArray23867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Array>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getArray23867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Array;
		}
		internal static global::MonoJavaBridge.MethodId _next23868;
		 bool java.sql.ResultSet.next() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._next23868);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._next23868);
		}
		internal static global::MonoJavaBridge.MethodId _getURL23869;
		 global::java.net.URL java.sql.ResultSet.getURL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getURL23869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getURL23869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _getURL23870;
		 global::java.net.URL java.sql.ResultSet.getURL(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getURL23870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getURL23870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.net.URL;
		}
		internal static global::MonoJavaBridge.MethodId _close23871;
		 void java.sql.ResultSet.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._close23871);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._close23871);
		}
		internal static global::MonoJavaBridge.MethodId _getType23872;
		 int java.sql.ResultSet.getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getType23872);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getType23872);
		}
		internal static global::MonoJavaBridge.MethodId _previous23873;
		 bool java.sql.ResultSet.previous() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._previous23873);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._previous23873);
		}
		internal static global::MonoJavaBridge.MethodId _getRef23874;
		 global::java.sql.Ref java.sql.ResultSet.getRef(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getRef23874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getRef23874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getRef23875;
		 global::java.sql.Ref java.sql.ResultSet.getRef(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getRef23875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Ref>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getRef23875, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Ref;
		}
		internal static global::MonoJavaBridge.MethodId _getString23876;
		 global::java.lang.String java.sql.ResultSet.getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getString23876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getString23876, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString23877;
		 global::java.lang.String java.sql.ResultSet.getString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getString23877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getString23877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst23878;
		 bool java.sql.ResultSet.isFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isFirst23878);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isFirst23878);
		}
		internal static global::MonoJavaBridge.MethodId _getTime23879;
		 global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTime23879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTime23879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime23880;
		 global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTime23880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTime23880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime23881;
		 global::java.sql.Time java.sql.ResultSet.getTime(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTime23881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTime23881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getTime23882;
		 global::java.sql.Time java.sql.ResultSet.getTime(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTime23882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTime23882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _getDate23883;
		 global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDate23883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDate23883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate23884;
		 global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDate23884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDate23884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate23885;
		 global::java.sql.Date java.sql.ResultSet.getDate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDate23885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDate23885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _getDate23886;
		 global::java.sql.Date java.sql.ResultSet.getDate(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getDate23886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getDate23886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Date;
		}
		internal static global::MonoJavaBridge.MethodId _isClosed23887;
		 bool java.sql.ResultSet.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isClosed23887);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isClosed23887);
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp23888;
		 global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTimestamp23888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTimestamp23888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp23889;
		 global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTimestamp23889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTimestamp23889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp23890;
		 global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0, java.util.Calendar arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTimestamp23890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTimestamp23890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _getTimestamp23891;
		 global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getTimestamp23891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getTimestamp23891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Timestamp;
		}
		internal static global::MonoJavaBridge.MethodId _last23892;
		 bool java.sql.ResultSet.last() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._last23892);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._last23892);
		}
		internal static global::MonoJavaBridge.MethodId _first23893;
		 bool java.sql.ResultSet.first() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._first23893);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._first23893);
		}
		internal static global::MonoJavaBridge.MethodId _updateBytes23894;
		 void java.sql.ResultSet.updateBytes(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBytes23894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBytes23894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBytes23895;
		 void java.sql.ResultSet.updateBytes(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBytes23895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBytes23895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isLast23896;
		 bool java.sql.ResultSet.isLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isLast23896);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isLast23896);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst23897;
		 bool java.sql.ResultSet.isBeforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isBeforeFirst23897);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isBeforeFirst23897);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast23898;
		 bool java.sql.ResultSet.isAfterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._isAfterLast23898);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._isAfterLast23898);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob23899;
		 global::java.sql.Blob java.sql.ResultSet.getBlob(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBlob23899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBlob23899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _getBlob23900;
		 global::java.sql.Blob java.sql.ResultSet.getBlob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBlob23900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Blob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBlob23900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Blob;
		}
		internal static global::MonoJavaBridge.MethodId _updateDate23901;
		 void java.sql.ResultSet.updateDate(int arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateDate23901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateDate23901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDate23902;
		 void java.sql.ResultSet.updateDate(java.lang.String arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateDate23902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateDate23902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime23903;
		 void java.sql.ResultSet.updateTime(int arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateTime23903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateTime23903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTime23904;
		 void java.sql.ResultSet.updateTime(java.lang.String arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateTime23904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateTime23904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _deleteRow23905;
		 void java.sql.ResultSet.deleteRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._deleteRow23905);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._deleteRow23905);
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob23906;
		 void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob23906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob23906, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob23907;
		 void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob23907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob23907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob23908;
		 void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob23908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob23908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob23909;
		 void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob23909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob23909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob23910;
		 void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob23910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob23910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBlob23911;
		 void java.sql.ResultSet.updateBlob(int arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBlob23911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBlob23911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble23912;
		 void java.sql.ResultSet.updateDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateDouble23912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateDouble23912, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateDouble23913;
		 void java.sql.ResultSet.updateDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateDouble23913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateDouble23913, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat23914;
		 void java.sql.ResultSet.updateFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateFloat23914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateFloat23914, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateFloat23915;
		 void java.sql.ResultSet.updateFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateFloat23915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateFloat23915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt23916;
		 void java.sql.ResultSet.updateInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateInt23916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateInt23916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateInt23917;
		 void java.sql.ResultSet.updateInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateInt23917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateInt23917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong23918;
		 void java.sql.ResultSet.updateLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateLong23918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateLong23918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateLong23919;
		 void java.sql.ResultSet.updateLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateLong23919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateLong23919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort23920;
		 void java.sql.ResultSet.updateShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateShort23920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateShort23920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateShort23921;
		 void java.sql.ResultSet.updateShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateShort23921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateShort23921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString23922;
		 void java.sql.ResultSet.updateString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateString23922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateString23922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateString23923;
		 void java.sql.ResultSet.updateString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateString23923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateString23923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _wasNull23924;
		 bool java.sql.ResultSet.wasNull() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._wasNull23924);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._wasNull23924);
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal23925;
		 global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBigDecimal23925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBigDecimal23925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal23926;
		 global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBigDecimal23926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBigDecimal23926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal23927;
		 global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBigDecimal23927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBigDecimal23927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getBigDecimal23928;
		 global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBigDecimal23928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBigDecimal23928, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.math.BigDecimal;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream23929;
		 global::java.io.InputStream java.sql.ResultSet.getAsciiStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getAsciiStream23929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getAsciiStream23929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getAsciiStream23930;
		 global::java.io.InputStream java.sql.ResultSet.getAsciiStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getAsciiStream23930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getAsciiStream23930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeStream23931;
		 global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getUnicodeStream23931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getUnicodeStream23931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getUnicodeStream23932;
		 global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getUnicodeStream23932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getUnicodeStream23932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream23933;
		 global::java.io.InputStream java.sql.ResultSet.getBinaryStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBinaryStream23933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBinaryStream23933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getBinaryStream23934;
		 global::java.io.InputStream java.sql.ResultSet.getBinaryStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getBinaryStream23934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getBinaryStream23934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings23935;
		 global::java.sql.SQLWarning java.sql.ResultSet.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getWarnings23935)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getWarnings23935)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings23936;
		 void java.sql.ResultSet.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._clearWarnings23936);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._clearWarnings23936);
		}
		internal static global::MonoJavaBridge.MethodId _getCursorName23937;
		 global::java.lang.String java.sql.ResultSet.getCursorName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getCursorName23937)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getCursorName23937)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData23938;
		 global::java.sql.ResultSetMetaData java.sql.ResultSet.getMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getMetaData23938)) as java.sql.ResultSetMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getMetaData23938)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _findColumn23939;
		 int java.sql.ResultSet.findColumn(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._findColumn23939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._findColumn23939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream23940;
		 global::java.io.Reader java.sql.ResultSet.getCharacterStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getCharacterStream23940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getCharacterStream23940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getCharacterStream23941;
		 global::java.io.Reader java.sql.ResultSet.getCharacterStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getCharacterStream23941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getCharacterStream23941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _beforeFirst23942;
		 void java.sql.ResultSet.beforeFirst() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._beforeFirst23942);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._beforeFirst23942);
		}
		internal static global::MonoJavaBridge.MethodId _afterLast23943;
		 void java.sql.ResultSet.afterLast() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._afterLast23943);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._afterLast23943);
		}
		internal static global::MonoJavaBridge.MethodId _getRow23944;
		 int java.sql.ResultSet.getRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getRow23944);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getRow23944);
		}
		internal static global::MonoJavaBridge.MethodId _absolute23945;
		 bool java.sql.ResultSet.absolute(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._absolute23945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._absolute23945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _relative23946;
		 bool java.sql.ResultSet.relative(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._relative23946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._relative23946, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection23947;
		 void java.sql.ResultSet.setFetchDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setFetchDirection23947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setFetchDirection23947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection23948;
		 int java.sql.ResultSet.getFetchDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getFetchDirection23948);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getFetchDirection23948);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize23949;
		 void java.sql.ResultSet.setFetchSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._setFetchSize23949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._setFetchSize23949, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize23950;
		 int java.sql.ResultSet.getFetchSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getFetchSize23950);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getFetchSize23950);
		}
		internal static global::MonoJavaBridge.MethodId _getConcurrency23951;
		 int java.sql.ResultSet.getConcurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getConcurrency23951);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getConcurrency23951);
		}
		internal static global::MonoJavaBridge.MethodId _rowUpdated23952;
		 bool java.sql.ResultSet.rowUpdated() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._rowUpdated23952);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._rowUpdated23952);
		}
		internal static global::MonoJavaBridge.MethodId _rowInserted23953;
		 bool java.sql.ResultSet.rowInserted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._rowInserted23953);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._rowInserted23953);
		}
		internal static global::MonoJavaBridge.MethodId _rowDeleted23954;
		 bool java.sql.ResultSet.rowDeleted() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_._rowDeleted23954);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._rowDeleted23954);
		}
		internal static global::MonoJavaBridge.MethodId _updateNull23955;
		 void java.sql.ResultSet.updateNull(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNull23955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNull23955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateNull23956;
		 void java.sql.ResultSet.updateNull(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNull23956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNull23956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _updateBoolean23957;
		 void java.sql.ResultSet.updateBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBoolean23957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBoolean23957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBoolean23958;
		 void java.sql.ResultSet.updateBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBoolean23958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBoolean23958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateByte23959;
		 void java.sql.ResultSet.updateByte(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateByte23959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateByte23959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateByte23960;
		 void java.sql.ResultSet.updateByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateByte23960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateByte23960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBigDecimal23961;
		 void java.sql.ResultSet.updateBigDecimal(int arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBigDecimal23961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBigDecimal23961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBigDecimal23962;
		 void java.sql.ResultSet.updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBigDecimal23962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBigDecimal23962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTimestamp23963;
		 void java.sql.ResultSet.updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateTimestamp23963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateTimestamp23963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateTimestamp23964;
		 void java.sql.ResultSet.updateTimestamp(int arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateTimestamp23964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateTimestamp23964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream23965;
		 void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream23965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream23965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream23966;
		 void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream23966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream23966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream23967;
		 void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream23967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream23967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream23968;
		 void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream23968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream23968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream23969;
		 void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream23969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream23969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateAsciiStream23970;
		 void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateAsciiStream23970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateAsciiStream23970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream23971;
		 void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream23971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream23971, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream23972;
		 void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream23972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream23972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream23973;
		 void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream23973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream23973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream23974;
		 void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream23974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream23974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream23975;
		 void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream23975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream23975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateBinaryStream23976;
		 void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateBinaryStream23976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateBinaryStream23976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream23977;
		 void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream23977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream23977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream23978;
		 void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream23978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream23978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream23979;
		 void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream23979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream23979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream23980;
		 void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream23980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream23980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream23981;
		 void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream23981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream23981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateCharacterStream23982;
		 void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateCharacterStream23982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateCharacterStream23982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject23983;
		 void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateObject23983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateObject23983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject23984;
		 void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateObject23984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateObject23984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject23985;
		 void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateObject23985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateObject23985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateObject23986;
		 void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateObject23986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateObject23986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insertRow23987;
		 void java.sql.ResultSet.insertRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._insertRow23987);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._insertRow23987);
		}
		internal static global::MonoJavaBridge.MethodId _updateRow23988;
		 void java.sql.ResultSet.updateRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateRow23988);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateRow23988);
		}
		internal static global::MonoJavaBridge.MethodId _refreshRow23989;
		 void java.sql.ResultSet.refreshRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._refreshRow23989);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._refreshRow23989);
		}
		internal static global::MonoJavaBridge.MethodId _cancelRowUpdates23990;
		 void java.sql.ResultSet.cancelRowUpdates() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._cancelRowUpdates23990);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._cancelRowUpdates23990);
		}
		internal static global::MonoJavaBridge.MethodId _moveToInsertRow23991;
		 void java.sql.ResultSet.moveToInsertRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._moveToInsertRow23991);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._moveToInsertRow23991);
		}
		internal static global::MonoJavaBridge.MethodId _moveToCurrentRow23992;
		 void java.sql.ResultSet.moveToCurrentRow() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._moveToCurrentRow23992);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._moveToCurrentRow23992);
		}
		internal static global::MonoJavaBridge.MethodId _getStatement23993;
		 global::java.sql.Statement java.sql.ResultSet.getStatement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getStatement23993)) as java.sql.Statement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Statement>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getStatement23993)) as java.sql.Statement;
		}
		internal static global::MonoJavaBridge.MethodId _getClob23994;
		 global::java.sql.Clob java.sql.ResultSet.getClob(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getClob23994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getClob23994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _getClob23995;
		 global::java.sql.Clob java.sql.ResultSet.getClob(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getClob23995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Clob>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getClob23995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Clob;
		}
		internal static global::MonoJavaBridge.MethodId _updateRef23996;
		 void java.sql.ResultSet.updateRef(java.lang.String arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateRef23996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateRef23996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateRef23997;
		 void java.sql.ResultSet.updateRef(int arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateRef23997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateRef23997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob23998;
		 void java.sql.ResultSet.updateClob(java.lang.String arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob23998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob23998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob23999;
		 void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob23999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob23999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24000;
		 void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob24000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob24000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24001;
		 void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob24001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob24001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24002;
		 void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob24002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob24002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateClob24003;
		 void java.sql.ResultSet.updateClob(int arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateClob24003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateClob24003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateArray24004;
		 void java.sql.ResultSet.updateArray(int arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateArray24004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateArray24004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateArray24005;
		 void java.sql.ResultSet.updateArray(java.lang.String arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateArray24005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateArray24005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getHoldability24006;
		 int java.sql.ResultSet.getHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.sql.RowSet_._getHoldability24006);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getHoldability24006);
		}
		internal static global::MonoJavaBridge.MethodId _updateNString24007;
		 void java.sql.ResultSet.updateNString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNString24007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNString24007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNString24008;
		 void java.sql.ResultSet.updateNString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNString24008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNString24008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob24009;
		 void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNClob24009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNClob24009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob24010;
		 void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNClob24010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNClob24010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob24011;
		 void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNClob24011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNClob24011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNClob24012;
		 void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNClob24012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNClob24012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getNString24013;
		 global::java.lang.String java.sql.ResultSet.getNString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getNString24013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getNString24013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNString24014;
		 global::java.lang.String java.sql.ResultSet.getNString(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getNString24014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getNString24014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream24015;
		 global::java.io.Reader java.sql.ResultSet.getNCharacterStream(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getNCharacterStream24015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getNCharacterStream24015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _getNCharacterStream24016;
		 global::java.io.Reader java.sql.ResultSet.getNCharacterStream(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.sql.RowSet_._getNCharacterStream24016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._getNCharacterStream24016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Reader;
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream24017;
		 void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNCharacterStream24017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNCharacterStream24017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream24018;
		 void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNCharacterStream24018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNCharacterStream24018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream24019;
		 void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNCharacterStream24019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNCharacterStream24019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _updateNCharacterStream24020;
		 void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::javax.sql.RowSet_._updateNCharacterStream24020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::javax.sql.RowSet_.staticClass, global::javax.sql.RowSet_._updateNCharacterStream24020, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSet"));
			global::javax.sql.RowSet_._setReadOnly23737 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setReadOnly", "(Z)V");
			global::javax.sql.RowSet_._setBoolean23738 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBoolean", "(Ljava/lang/String;Z)V");
			global::javax.sql.RowSet_._setBoolean23739 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBoolean", "(IZ)V");
			global::javax.sql.RowSet_._setByte23740 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setByte", "(Ljava/lang/String;B)V");
			global::javax.sql.RowSet_._setByte23741 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setByte", "(IB)V");
			global::javax.sql.RowSet_._setShort23742 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setShort", "(IS)V");
			global::javax.sql.RowSet_._setShort23743 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setShort", "(Ljava/lang/String;S)V");
			global::javax.sql.RowSet_._setInt23744 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setInt", "(Ljava/lang/String;I)V");
			global::javax.sql.RowSet_._setInt23745 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setInt", "(II)V");
			global::javax.sql.RowSet_._setLong23746 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setLong", "(IJ)V");
			global::javax.sql.RowSet_._setLong23747 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setLong", "(Ljava/lang/String;J)V");
			global::javax.sql.RowSet_._setFloat23748 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setFloat", "(Ljava/lang/String;F)V");
			global::javax.sql.RowSet_._setFloat23749 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setFloat", "(IF)V");
			global::javax.sql.RowSet_._setDouble23750 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDouble", "(ID)V");
			global::javax.sql.RowSet_._setDouble23751 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDouble", "(Ljava/lang/String;D)V");
			global::javax.sql.RowSet_._isReadOnly23752 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isReadOnly", "()Z");
			global::javax.sql.RowSet_._setTimestamp23753 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setTimestamp23754 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setTimestamp23755 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V");
			global::javax.sql.RowSet_._setTimestamp23756 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::javax.sql.RowSet_._setURL23757 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setURL", "(ILjava/net/URL;)V");
			global::javax.sql.RowSet_._setTime23758 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setTime23759 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::javax.sql.RowSet_._setTime23760 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setTime23761 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTime", "(ILjava/sql/Time;)V");
			global::javax.sql.RowSet_._setDate23762 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setDate23763 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDate", "(ILjava/sql/Date;)V");
			global::javax.sql.RowSet_._setDate23764 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V");
			global::javax.sql.RowSet_._setDate23765 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::javax.sql.RowSet_._execute23766 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "execute", "()V");
			global::javax.sql.RowSet_._setPassword23767 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setPassword", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._setType23768 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setType", "(I)V");
			global::javax.sql.RowSet_._getPassword23769 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getPassword", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setString23770 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setString", "(ILjava/lang/String;)V");
			global::javax.sql.RowSet_._setString23771 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.sql.RowSet_._setObject23772 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V");
			global::javax.sql.RowSet_._setObject23773 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;II)V");
			global::javax.sql.RowSet_._setObject23774 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;I)V");
			global::javax.sql.RowSet_._setObject23775 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::javax.sql.RowSet_._setObject23776 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.sql.RowSet_._setObject23777 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;)V");
			global::javax.sql.RowSet_._getUrl23778 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getUrl", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setUrl23779 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setUrl", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._setBytes23780 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBytes", "(Ljava/lang/String;[B)V");
			global::javax.sql.RowSet_._setBytes23781 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBytes", "(I[B)V");
			global::javax.sql.RowSet_._setBinaryStream23782 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::javax.sql.RowSet_._setBinaryStream23783 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V");
			global::javax.sql.RowSet_._setBinaryStream23784 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._setBinaryStream23785 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._setNull23786 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNull", "(Ljava/lang/String;ILjava/lang/String;)V");
			global::javax.sql.RowSet_._setNull23787 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNull", "(IILjava/lang/String;)V");
			global::javax.sql.RowSet_._setNull23788 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNull", "(II)V");
			global::javax.sql.RowSet_._setNull23789 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNull", "(Ljava/lang/String;I)V");
			global::javax.sql.RowSet_._setBigDecimal23790 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::javax.sql.RowSet_._setBigDecimal23791 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::javax.sql.RowSet_._setAsciiStream23792 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V");
			global::javax.sql.RowSet_._setAsciiStream23793 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::javax.sql.RowSet_._setAsciiStream23794 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._setAsciiStream23795 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._setCharacterStream23796 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::javax.sql.RowSet_._setCharacterStream23797 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._setCharacterStream23798 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._setCharacterStream23799 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V");
			global::javax.sql.RowSet_._setNString23800 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.sql.RowSet_._setNString23801 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNString", "(ILjava/lang/String;)V");
			global::javax.sql.RowSet_._setNCharacterStream23802 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._setNCharacterStream23803 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._setNCharacterStream23804 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._setNCharacterStream23805 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._setNClob23806 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._setNClob23807 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNClob", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._setNClob23808 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._setNClob23809 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setNClob", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._setClob23810 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._setClob23811 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::javax.sql.RowSet_._setClob23812 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._setClob23813 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/sql/Clob;)V");
			global::javax.sql.RowSet_._setClob23814 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._setClob23815 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._setBlob23816 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._setBlob23817 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::javax.sql.RowSet_._setBlob23818 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._setBlob23819 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/sql/Blob;)V");
			global::javax.sql.RowSet_._setBlob23820 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V");
			global::javax.sql.RowSet_._setBlob23821 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::javax.sql.RowSet_._clearParameters23822 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "clearParameters", "()V");
			global::javax.sql.RowSet_._setRef23823 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setRef", "(ILjava/sql/Ref;)V");
			global::javax.sql.RowSet_._setArray23824 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setArray", "(ILjava/sql/Array;)V");
			global::javax.sql.RowSet_._getMaxFieldSize23825 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getMaxFieldSize", "()I");
			global::javax.sql.RowSet_._setMaxFieldSize23826 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setMaxFieldSize", "(I)V");
			global::javax.sql.RowSet_._getMaxRows23827 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getMaxRows", "()I");
			global::javax.sql.RowSet_._setMaxRows23828 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setMaxRows", "(I)V");
			global::javax.sql.RowSet_._setEscapeProcessing23829 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setEscapeProcessing", "(Z)V");
			global::javax.sql.RowSet_._getQueryTimeout23830 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getQueryTimeout", "()I");
			global::javax.sql.RowSet_._setQueryTimeout23831 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setQueryTimeout", "(I)V");
			global::javax.sql.RowSet_._setTransactionIsolation23832 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTransactionIsolation", "(I)V");
			global::javax.sql.RowSet_._getTransactionIsolation23833 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTransactionIsolation", "()I");
			global::javax.sql.RowSet_._getTypeMap23834 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTypeMap", "()Ljava/util/Map;");
			global::javax.sql.RowSet_._setTypeMap23835 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setTypeMap", "(Ljava/util/Map;)V");
			global::javax.sql.RowSet_._getDataSourceName23836 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDataSourceName", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setDataSourceName23837 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setDataSourceName", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._getUsername23838 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getUsername", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setUsername23839 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setUsername", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._getCommand23840 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getCommand", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._setCommand23841 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setCommand", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._getEscapeProcessing23842 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getEscapeProcessing", "()Z");
			global::javax.sql.RowSet_._setConcurrency23843 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setConcurrency", "(I)V");
			global::javax.sql.RowSet_._addRowSetListener23844 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "addRowSetListener", "(Ljavax/sql/RowSetListener;)V");
			global::javax.sql.RowSet_._removeRowSetListener23845 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "removeRowSetListener", "(Ljavax/sql/RowSetListener;)V");
			global::javax.sql.RowSet_._getObject23846 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::javax.sql.RowSet_._getObject23847 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;");
			global::javax.sql.RowSet_._getObject23848 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getObject", "(I)Ljava/lang/Object;");
			global::javax.sql.RowSet_._getObject23849 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;");
			global::javax.sql.RowSet_._getBoolean23850 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::javax.sql.RowSet_._getBoolean23851 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBoolean", "(I)Z");
			global::javax.sql.RowSet_._getByte23852 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::javax.sql.RowSet_._getByte23853 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getByte", "(I)B");
			global::javax.sql.RowSet_._getShort23854 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getShort", "(I)S");
			global::javax.sql.RowSet_._getShort23855 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::javax.sql.RowSet_._getInt23856 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::javax.sql.RowSet_._getInt23857 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getInt", "(I)I");
			global::javax.sql.RowSet_._getLong23858 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::javax.sql.RowSet_._getLong23859 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getLong", "(I)J");
			global::javax.sql.RowSet_._getFloat23860 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::javax.sql.RowSet_._getFloat23861 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getFloat", "(I)F");
			global::javax.sql.RowSet_._getDouble23862 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDouble", "(I)D");
			global::javax.sql.RowSet_._getDouble23863 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::javax.sql.RowSet_._getBytes23864 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBytes", "(Ljava/lang/String;)[B");
			global::javax.sql.RowSet_._getBytes23865 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBytes", "(I)[B");
			global::javax.sql.RowSet_._getArray23866 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;");
			global::javax.sql.RowSet_._getArray23867 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getArray", "(I)Ljava/sql/Array;");
			global::javax.sql.RowSet_._next23868 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "next", "()Z");
			global::javax.sql.RowSet_._getURL23869 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;");
			global::javax.sql.RowSet_._getURL23870 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getURL", "(I)Ljava/net/URL;");
			global::javax.sql.RowSet_._close23871 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "close", "()V");
			global::javax.sql.RowSet_._getType23872 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getType", "()I");
			global::javax.sql.RowSet_._previous23873 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "previous", "()Z");
			global::javax.sql.RowSet_._getRef23874 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getRef", "(I)Ljava/sql/Ref;");
			global::javax.sql.RowSet_._getRef23875 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;");
			global::javax.sql.RowSet_._getString23876 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.sql.RowSet_._getString23877 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getString", "(I)Ljava/lang/String;");
			global::javax.sql.RowSet_._isFirst23878 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isFirst", "()Z");
			global::javax.sql.RowSet_._getTime23879 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;");
			global::javax.sql.RowSet_._getTime23880 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::javax.sql.RowSet_._getTime23881 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;");
			global::javax.sql.RowSet_._getTime23882 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTime", "(I)Ljava/sql/Time;");
			global::javax.sql.RowSet_._getDate23883 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;");
			global::javax.sql.RowSet_._getDate23884 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;");
			global::javax.sql.RowSet_._getDate23885 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDate", "(I)Ljava/sql/Date;");
			global::javax.sql.RowSet_._getDate23886 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;");
			global::javax.sql.RowSet_._isClosed23887 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isClosed", "()Z");
			global::javax.sql.RowSet_._getTimestamp23888 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;");
			global::javax.sql.RowSet_._getTimestamp23889 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;");
			global::javax.sql.RowSet_._getTimestamp23890 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;");
			global::javax.sql.RowSet_._getTimestamp23891 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;");
			global::javax.sql.RowSet_._last23892 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "last", "()Z");
			global::javax.sql.RowSet_._first23893 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "first", "()Z");
			global::javax.sql.RowSet_._updateBytes23894 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBytes", "(Ljava/lang/String;[B)V");
			global::javax.sql.RowSet_._updateBytes23895 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBytes", "(I[B)V");
			global::javax.sql.RowSet_._isLast23896 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isLast", "()Z");
			global::javax.sql.RowSet_._isBeforeFirst23897 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isBeforeFirst", "()Z");
			global::javax.sql.RowSet_._isAfterLast23898 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "isAfterLast", "()Z");
			global::javax.sql.RowSet_._getBlob23899 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;");
			global::javax.sql.RowSet_._getBlob23900 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBlob", "(I)Ljava/sql/Blob;");
			global::javax.sql.RowSet_._updateDate23901 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateDate", "(ILjava/sql/Date;)V");
			global::javax.sql.RowSet_._updateDate23902 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V");
			global::javax.sql.RowSet_._updateTime23903 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateTime", "(ILjava/sql/Time;)V");
			global::javax.sql.RowSet_._updateTime23904 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V");
			global::javax.sql.RowSet_._deleteRow23905 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "deleteRow", "()V");
			global::javax.sql.RowSet_._updateBlob23906 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V");
			global::javax.sql.RowSet_._updateBlob23907 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateBlob23908 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateBlob23909 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateBlob23910 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateBlob23911 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/sql/Blob;)V");
			global::javax.sql.RowSet_._updateDouble23912 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateDouble", "(ID)V");
			global::javax.sql.RowSet_._updateDouble23913 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateDouble", "(Ljava/lang/String;D)V");
			global::javax.sql.RowSet_._updateFloat23914 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateFloat", "(Ljava/lang/String;F)V");
			global::javax.sql.RowSet_._updateFloat23915 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateFloat", "(IF)V");
			global::javax.sql.RowSet_._updateInt23916 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateInt", "(Ljava/lang/String;I)V");
			global::javax.sql.RowSet_._updateInt23917 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateInt", "(II)V");
			global::javax.sql.RowSet_._updateLong23918 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateLong", "(Ljava/lang/String;J)V");
			global::javax.sql.RowSet_._updateLong23919 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateLong", "(IJ)V");
			global::javax.sql.RowSet_._updateShort23920 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateShort", "(IS)V");
			global::javax.sql.RowSet_._updateShort23921 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateShort", "(Ljava/lang/String;S)V");
			global::javax.sql.RowSet_._updateString23922 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateString", "(ILjava/lang/String;)V");
			global::javax.sql.RowSet_._updateString23923 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.sql.RowSet_._wasNull23924 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "wasNull", "()Z");
			global::javax.sql.RowSet_._getBigDecimal23925 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;");
			global::javax.sql.RowSet_._getBigDecimal23926 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;");
			global::javax.sql.RowSet_._getBigDecimal23927 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;");
			global::javax.sql.RowSet_._getBigDecimal23928 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;");
			global::javax.sql.RowSet_._getAsciiStream23929 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getAsciiStream23930 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getAsciiStream", "(I)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getUnicodeStream23931 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getUnicodeStream23932 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getUnicodeStream", "(I)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getBinaryStream23933 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBinaryStream", "(I)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getBinaryStream23934 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;");
			global::javax.sql.RowSet_._getWarnings23935 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::javax.sql.RowSet_._clearWarnings23936 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "clearWarnings", "()V");
			global::javax.sql.RowSet_._getCursorName23937 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getCursorName", "()Ljava/lang/String;");
			global::javax.sql.RowSet_._getMetaData23938 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::javax.sql.RowSet_._findColumn23939 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "findColumn", "(Ljava/lang/String;)I");
			global::javax.sql.RowSet_._getCharacterStream23940 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::javax.sql.RowSet_._getCharacterStream23941 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;");
			global::javax.sql.RowSet_._beforeFirst23942 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "beforeFirst", "()V");
			global::javax.sql.RowSet_._afterLast23943 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "afterLast", "()V");
			global::javax.sql.RowSet_._getRow23944 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getRow", "()I");
			global::javax.sql.RowSet_._absolute23945 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "absolute", "(I)Z");
			global::javax.sql.RowSet_._relative23946 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "relative", "(I)Z");
			global::javax.sql.RowSet_._setFetchDirection23947 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setFetchDirection", "(I)V");
			global::javax.sql.RowSet_._getFetchDirection23948 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getFetchDirection", "()I");
			global::javax.sql.RowSet_._setFetchSize23949 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "setFetchSize", "(I)V");
			global::javax.sql.RowSet_._getFetchSize23950 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getFetchSize", "()I");
			global::javax.sql.RowSet_._getConcurrency23951 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getConcurrency", "()I");
			global::javax.sql.RowSet_._rowUpdated23952 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "rowUpdated", "()Z");
			global::javax.sql.RowSet_._rowInserted23953 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "rowInserted", "()Z");
			global::javax.sql.RowSet_._rowDeleted23954 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "rowDeleted", "()Z");
			global::javax.sql.RowSet_._updateNull23955 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNull", "(Ljava/lang/String;)V");
			global::javax.sql.RowSet_._updateNull23956 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNull", "(I)V");
			global::javax.sql.RowSet_._updateBoolean23957 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBoolean", "(IZ)V");
			global::javax.sql.RowSet_._updateBoolean23958 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBoolean", "(Ljava/lang/String;Z)V");
			global::javax.sql.RowSet_._updateByte23959 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateByte", "(IB)V");
			global::javax.sql.RowSet_._updateByte23960 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateByte", "(Ljava/lang/String;B)V");
			global::javax.sql.RowSet_._updateBigDecimal23961 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::javax.sql.RowSet_._updateBigDecimal23962 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V");
			global::javax.sql.RowSet_._updateTimestamp23963 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V");
			global::javax.sql.RowSet_._updateTimestamp23964 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateTimestamp", "(ILjava/sql/Timestamp;)V");
			global::javax.sql.RowSet_._updateAsciiStream23965 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateAsciiStream23966 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateAsciiStream23967 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateAsciiStream23968 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::javax.sql.RowSet_._updateAsciiStream23969 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateAsciiStream23970 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;I)V");
			global::javax.sql.RowSet_._updateBinaryStream23971 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V");
			global::javax.sql.RowSet_._updateBinaryStream23972 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;I)V");
			global::javax.sql.RowSet_._updateBinaryStream23973 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateBinaryStream23974 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V");
			global::javax.sql.RowSet_._updateBinaryStream23975 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateBinaryStream23976 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V");
			global::javax.sql.RowSet_._updateCharacterStream23977 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V");
			global::javax.sql.RowSet_._updateCharacterStream23978 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;I)V");
			global::javax.sql.RowSet_._updateCharacterStream23979 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateCharacterStream23980 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateCharacterStream23981 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._updateCharacterStream23982 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._updateObject23983 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::javax.sql.RowSet_._updateObject23984 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateObject", "(ILjava/lang/Object;)V");
			global::javax.sql.RowSet_._updateObject23985 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateObject", "(ILjava/lang/Object;I)V");
			global::javax.sql.RowSet_._updateObject23986 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V");
			global::javax.sql.RowSet_._insertRow23987 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "insertRow", "()V");
			global::javax.sql.RowSet_._updateRow23988 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateRow", "()V");
			global::javax.sql.RowSet_._refreshRow23989 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "refreshRow", "()V");
			global::javax.sql.RowSet_._cancelRowUpdates23990 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "cancelRowUpdates", "()V");
			global::javax.sql.RowSet_._moveToInsertRow23991 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "moveToInsertRow", "()V");
			global::javax.sql.RowSet_._moveToCurrentRow23992 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "moveToCurrentRow", "()V");
			global::javax.sql.RowSet_._getStatement23993 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getStatement", "()Ljava/sql/Statement;");
			global::javax.sql.RowSet_._getClob23994 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;");
			global::javax.sql.RowSet_._getClob23995 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getClob", "(I)Ljava/sql/Clob;");
			global::javax.sql.RowSet_._updateRef23996 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V");
			global::javax.sql.RowSet_._updateRef23997 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateRef", "(ILjava/sql/Ref;)V");
			global::javax.sql.RowSet_._updateClob23998 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V");
			global::javax.sql.RowSet_._updateClob23999 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._updateClob24000 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._updateClob24001 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateClob24002 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateClob24003 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/sql/Clob;)V");
			global::javax.sql.RowSet_._updateArray24004 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateArray", "(ILjava/sql/Array;)V");
			global::javax.sql.RowSet_._updateArray24005 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V");
			global::javax.sql.RowSet_._getHoldability24006 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getHoldability", "()I");
			global::javax.sql.RowSet_._updateNString24007 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::javax.sql.RowSet_._updateNString24008 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNString", "(ILjava/lang/String;)V");
			global::javax.sql.RowSet_._updateNClob24009 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNClob", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._updateNClob24010 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNClob", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateNClob24011 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateNClob24012 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V");
			global::javax.sql.RowSet_._getNString24013 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::javax.sql.RowSet_._getNString24014 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getNString", "(I)Ljava/lang/String;");
			global::javax.sql.RowSet_._getNCharacterStream24015 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;");
			global::javax.sql.RowSet_._getNCharacterStream24016 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;");
			global::javax.sql.RowSet_._updateNCharacterStream24017 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;)V");
			global::javax.sql.RowSet_._updateNCharacterStream24018 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateNCharacterStream24019 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;J)V");
			global::javax.sql.RowSet_._updateNCharacterStream24020 = @__env.GetMethodIDNoThrow(global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V");
		}
	}
}
