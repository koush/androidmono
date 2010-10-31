namespace javax.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.sql.RowSet_))]
	public partial interface RowSet : java.sql.ResultSet
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
	internal sealed partial class RowSet_ : java.lang.Object, RowSet
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RowSet_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void javax.sql.RowSet.setReadOnly(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setReadOnly", "(Z)V", ref global::javax.sql.RowSet_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void javax.sql.RowSet.setBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBoolean", "(Ljava/lang/String;Z)V", ref global::javax.sql.RowSet_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void javax.sql.RowSet.setBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBoolean", "(IZ)V", ref global::javax.sql.RowSet_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void javax.sql.RowSet.setByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setByte", "(Ljava/lang/String;B)V", ref global::javax.sql.RowSet_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void javax.sql.RowSet.setByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setByte", "(IB)V", ref global::javax.sql.RowSet_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void javax.sql.RowSet.setShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setShort", "(IS)V", ref global::javax.sql.RowSet_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void javax.sql.RowSet.setShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setShort", "(Ljava/lang/String;S)V", ref global::javax.sql.RowSet_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void javax.sql.RowSet.setInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setInt", "(Ljava/lang/String;I)V", ref global::javax.sql.RowSet_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void javax.sql.RowSet.setInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setInt", "(II)V", ref global::javax.sql.RowSet_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void javax.sql.RowSet.setLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setLong", "(IJ)V", ref global::javax.sql.RowSet_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void javax.sql.RowSet.setLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setLong", "(Ljava/lang/String;J)V", ref global::javax.sql.RowSet_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void javax.sql.RowSet.setFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setFloat", "(Ljava/lang/String;F)V", ref global::javax.sql.RowSet_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void javax.sql.RowSet.setFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setFloat", "(IF)V", ref global::javax.sql.RowSet_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void javax.sql.RowSet.setDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setDouble", "(ID)V", ref global::javax.sql.RowSet_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		void javax.sql.RowSet.setDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setDouble", "(Ljava/lang/String;D)V", ref global::javax.sql.RowSet_._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		bool javax.sql.RowSet.isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "isReadOnly", "()Z", ref global::javax.sql.RowSet_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void javax.sql.RowSet.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", ref global::javax.sql.RowSet_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void javax.sql.RowSet.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V", ref global::javax.sql.RowSet_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void javax.sql.RowSet.setTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V", ref global::javax.sql.RowSet_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void javax.sql.RowSet.setTimestamp(java.lang.String arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", ref global::javax.sql.RowSet_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		void javax.sql.RowSet.setURL(int arg0, java.net.URL arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setURL", "(ILjava/net/URL;)V", ref global::javax.sql.RowSet_._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void javax.sql.RowSet.setTime(java.lang.String arg0, java.sql.Time arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V", ref global::javax.sql.RowSet_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void javax.sql.RowSet.setTime(java.lang.String arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V", ref global::javax.sql.RowSet_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void javax.sql.RowSet.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V", ref global::javax.sql.RowSet_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void javax.sql.RowSet.setTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTime", "(ILjava/sql/Time;)V", ref global::javax.sql.RowSet_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void javax.sql.RowSet.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V", ref global::javax.sql.RowSet_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		void javax.sql.RowSet.setDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setDate", "(ILjava/sql/Date;)V", ref global::javax.sql.RowSet_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		void javax.sql.RowSet.setDate(java.lang.String arg0, java.sql.Date arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V", ref global::javax.sql.RowSet_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		void javax.sql.RowSet.setDate(java.lang.String arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V", ref global::javax.sql.RowSet_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		void javax.sql.RowSet.execute()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "execute", "()V", ref global::javax.sql.RowSet_._m29);
		}
		private static global::MonoJavaBridge.MethodId _m30;
		void javax.sql.RowSet.setPassword(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setPassword", "(Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		void javax.sql.RowSet.setType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setType", "(I)V", ref global::javax.sql.RowSet_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		global::java.lang.String javax.sql.RowSet.getPassword()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getPassword", "()Ljava/lang/String;", ref global::javax.sql.RowSet_._m32) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		void javax.sql.RowSet.setString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setString", "(ILjava/lang/String;)V", ref global::javax.sql.RowSet_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void javax.sql.RowSet.setString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setString", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V", ref global::javax.sql.RowSet_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;II)V", ref global::javax.sql.RowSet_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;I)V", ref global::javax.sql.RowSet_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", ref global::javax.sql.RowSet_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		void javax.sql.RowSet.setObject(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.sql.RowSet_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		void javax.sql.RowSet.setObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setObject", "(ILjava/lang/Object;)V", ref global::javax.sql.RowSet_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		global::java.lang.String javax.sql.RowSet.getUrl()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getUrl", "()Ljava/lang/String;", ref global::javax.sql.RowSet_._m41) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m42;
		void javax.sql.RowSet.setUrl(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setUrl", "(Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		void javax.sql.RowSet.setBytes(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBytes", "(Ljava/lang/String;[B)V", ref global::javax.sql.RowSet_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		void javax.sql.RowSet.setBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBytes", "(I[B)V", ref global::javax.sql.RowSet_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		void javax.sql.RowSet.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", ref global::javax.sql.RowSet_._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		void javax.sql.RowSet.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V", ref global::javax.sql.RowSet_._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		void javax.sql.RowSet.setBinaryStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::javax.sql.RowSet_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		void javax.sql.RowSet.setBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V", ref global::javax.sql.RowSet_._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		void javax.sql.RowSet.setNull(java.lang.String arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNull", "(Ljava/lang/String;ILjava/lang/String;)V", ref global::javax.sql.RowSet_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		void javax.sql.RowSet.setNull(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNull", "(IILjava/lang/String;)V", ref global::javax.sql.RowSet_._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		void javax.sql.RowSet.setNull(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNull", "(II)V", ref global::javax.sql.RowSet_._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		void javax.sql.RowSet.setNull(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNull", "(Ljava/lang/String;I)V", ref global::javax.sql.RowSet_._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m53;
		void javax.sql.RowSet.setBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", ref global::javax.sql.RowSet_._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		void javax.sql.RowSet.setBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V", ref global::javax.sql.RowSet_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		void javax.sql.RowSet.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V", ref global::javax.sql.RowSet_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		void javax.sql.RowSet.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", ref global::javax.sql.RowSet_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		void javax.sql.RowSet.setAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V", ref global::javax.sql.RowSet_._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		void javax.sql.RowSet.setAsciiStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::javax.sql.RowSet_._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m59;
		void javax.sql.RowSet.setCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", ref global::javax.sql.RowSet_._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		void javax.sql.RowSet.setCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::javax.sql.RowSet_._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		void javax.sql.RowSet.setCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V", ref global::javax.sql.RowSet_._m61, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m62;
		void javax.sql.RowSet.setCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V", ref global::javax.sql.RowSet_._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		void javax.sql.RowSet.setNString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNString", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		void javax.sql.RowSet.setNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNString", "(ILjava/lang/String;)V", ref global::javax.sql.RowSet_._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		void javax.sql.RowSet.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V", ref global::javax.sql.RowSet_._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		void javax.sql.RowSet.setNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V", ref global::javax.sql.RowSet_._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		void javax.sql.RowSet.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::javax.sql.RowSet_._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		void javax.sql.RowSet.setNCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::javax.sql.RowSet_._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		void javax.sql.RowSet.setNClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::javax.sql.RowSet_._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		void javax.sql.RowSet.setNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNClob", "(ILjava/io/Reader;)V", ref global::javax.sql.RowSet_._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		void javax.sql.RowSet.setNClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::javax.sql.RowSet_._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		void javax.sql.RowSet.setNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setNClob", "(ILjava/io/Reader;J)V", ref global::javax.sql.RowSet_._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		void javax.sql.RowSet.setClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::javax.sql.RowSet_._m73, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m74;
		void javax.sql.RowSet.setClob(java.lang.String arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", ref global::javax.sql.RowSet_._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		void javax.sql.RowSet.setClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::javax.sql.RowSet_._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		void javax.sql.RowSet.setClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/sql/Clob;)V", ref global::javax.sql.RowSet_._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		void javax.sql.RowSet.setClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/io/Reader;J)V", ref global::javax.sql.RowSet_._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		void javax.sql.RowSet.setClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setClob", "(ILjava/io/Reader;)V", ref global::javax.sql.RowSet_._m78, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m79;
		void javax.sql.RowSet.setBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/io/InputStream;)V", ref global::javax.sql.RowSet_._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		void javax.sql.RowSet.setBlob(java.lang.String arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", ref global::javax.sql.RowSet_._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		void javax.sql.RowSet.setBlob(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::javax.sql.RowSet_._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		void javax.sql.RowSet.setBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/sql/Blob;)V", ref global::javax.sql.RowSet_._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m83;
		void javax.sql.RowSet.setBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V", ref global::javax.sql.RowSet_._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		void javax.sql.RowSet.setBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", ref global::javax.sql.RowSet_._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m85;
		void javax.sql.RowSet.clearParameters()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "clearParameters", "()V", ref global::javax.sql.RowSet_._m85);
		}
		private static global::MonoJavaBridge.MethodId _m86;
		void javax.sql.RowSet.setRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setRef", "(ILjava/sql/Ref;)V", ref global::javax.sql.RowSet_._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m87;
		void javax.sql.RowSet.setArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setArray", "(ILjava/sql/Array;)V", ref global::javax.sql.RowSet_._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		int javax.sql.RowSet.getMaxFieldSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getMaxFieldSize", "()I", ref global::javax.sql.RowSet_._m88);
		}
		private static global::MonoJavaBridge.MethodId _m89;
		void javax.sql.RowSet.setMaxFieldSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setMaxFieldSize", "(I)V", ref global::javax.sql.RowSet_._m89, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m90;
		int javax.sql.RowSet.getMaxRows()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getMaxRows", "()I", ref global::javax.sql.RowSet_._m90);
		}
		private static global::MonoJavaBridge.MethodId _m91;
		void javax.sql.RowSet.setMaxRows(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setMaxRows", "(I)V", ref global::javax.sql.RowSet_._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		void javax.sql.RowSet.setEscapeProcessing(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setEscapeProcessing", "(Z)V", ref global::javax.sql.RowSet_._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m93;
		int javax.sql.RowSet.getQueryTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getQueryTimeout", "()I", ref global::javax.sql.RowSet_._m93);
		}
		private static global::MonoJavaBridge.MethodId _m94;
		void javax.sql.RowSet.setQueryTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setQueryTimeout", "(I)V", ref global::javax.sql.RowSet_._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m95;
		void javax.sql.RowSet.setTransactionIsolation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTransactionIsolation", "(I)V", ref global::javax.sql.RowSet_._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m96;
		int javax.sql.RowSet.getTransactionIsolation()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getTransactionIsolation", "()I", ref global::javax.sql.RowSet_._m96);
		}
		private static global::MonoJavaBridge.MethodId _m97;
		global::java.util.Map javax.sql.RowSet.getTypeMap()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::javax.sql.RowSet_.staticClass, "getTypeMap", "()Ljava/util/Map;", ref global::javax.sql.RowSet_._m97) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m98;
		void javax.sql.RowSet.setTypeMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setTypeMap", "(Ljava/util/Map;)V", ref global::javax.sql.RowSet_._m98, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m99;
		global::java.lang.String javax.sql.RowSet.getDataSourceName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getDataSourceName", "()Ljava/lang/String;", ref global::javax.sql.RowSet_._m99) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m100;
		void javax.sql.RowSet.setDataSourceName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setDataSourceName", "(Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m101;
		global::java.lang.String javax.sql.RowSet.getUsername()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getUsername", "()Ljava/lang/String;", ref global::javax.sql.RowSet_._m101) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m102;
		void javax.sql.RowSet.setUsername(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setUsername", "(Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m103;
		global::java.lang.String javax.sql.RowSet.getCommand()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getCommand", "()Ljava/lang/String;", ref global::javax.sql.RowSet_._m103) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m104;
		void javax.sql.RowSet.setCommand(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setCommand", "(Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m105;
		bool javax.sql.RowSet.getEscapeProcessing()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "getEscapeProcessing", "()Z", ref global::javax.sql.RowSet_._m105);
		}
		private static global::MonoJavaBridge.MethodId _m106;
		void javax.sql.RowSet.setConcurrency(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setConcurrency", "(I)V", ref global::javax.sql.RowSet_._m106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m107;
		void javax.sql.RowSet.addRowSetListener(javax.sql.RowSetListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "addRowSetListener", "(Ljavax/sql/RowSetListener;)V", ref global::javax.sql.RowSet_._m107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m108;
		void javax.sql.RowSet.removeRowSetListener(javax.sql.RowSetListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "removeRowSetListener", "(Ljavax/sql/RowSetListener;)V", ref global::javax.sql.RowSet_._m108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m109;
		global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getObject", "(Ljava/lang/String;)Ljava/lang/Object;", ref global::javax.sql.RowSet_._m109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m110;
		global::java.lang.Object java.sql.ResultSet.getObject(int arg0, java.util.Map arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getObject", "(ILjava/util/Map;)Ljava/lang/Object;", ref global::javax.sql.RowSet_._m110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m111;
		global::java.lang.Object java.sql.ResultSet.getObject(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getObject", "(I)Ljava/lang/Object;", ref global::javax.sql.RowSet_._m111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m112;
		global::java.lang.Object java.sql.ResultSet.getObject(java.lang.String arg0, java.util.Map arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", ref global::javax.sql.RowSet_._m112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m113;
		bool java.sql.ResultSet.getBoolean(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "getBoolean", "(Ljava/lang/String;)Z", ref global::javax.sql.RowSet_._m113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m114;
		bool java.sql.ResultSet.getBoolean(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "getBoolean", "(I)Z", ref global::javax.sql.RowSet_._m114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m115;
		byte java.sql.ResultSet.getByte(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::javax.sql.RowSet_.staticClass, "getByte", "(Ljava/lang/String;)B", ref global::javax.sql.RowSet_._m115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m116;
		byte java.sql.ResultSet.getByte(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::javax.sql.RowSet_.staticClass, "getByte", "(I)B", ref global::javax.sql.RowSet_._m116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m117;
		short java.sql.ResultSet.getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::javax.sql.RowSet_.staticClass, "getShort", "(I)S", ref global::javax.sql.RowSet_._m117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m118;
		short java.sql.ResultSet.getShort(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::javax.sql.RowSet_.staticClass, "getShort", "(Ljava/lang/String;)S", ref global::javax.sql.RowSet_._m118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m119;
		int java.sql.ResultSet.getInt(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getInt", "(Ljava/lang/String;)I", ref global::javax.sql.RowSet_._m119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m120;
		int java.sql.ResultSet.getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getInt", "(I)I", ref global::javax.sql.RowSet_._m120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m121;
		long java.sql.ResultSet.getLong(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.sql.RowSet_.staticClass, "getLong", "(Ljava/lang/String;)J", ref global::javax.sql.RowSet_._m121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m122;
		long java.sql.ResultSet.getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::javax.sql.RowSet_.staticClass, "getLong", "(I)J", ref global::javax.sql.RowSet_._m122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m123;
		float java.sql.ResultSet.getFloat(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::javax.sql.RowSet_.staticClass, "getFloat", "(Ljava/lang/String;)F", ref global::javax.sql.RowSet_._m123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m124;
		float java.sql.ResultSet.getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::javax.sql.RowSet_.staticClass, "getFloat", "(I)F", ref global::javax.sql.RowSet_._m124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m125;
		double java.sql.ResultSet.getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::javax.sql.RowSet_.staticClass, "getDouble", "(I)D", ref global::javax.sql.RowSet_._m125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m126;
		double java.sql.ResultSet.getDouble(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::javax.sql.RowSet_.staticClass, "getDouble", "(Ljava/lang/String;)D", ref global::javax.sql.RowSet_._m126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m127;
		byte[] java.sql.ResultSet.getBytes(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.sql.RowSet_.staticClass, "getBytes", "(Ljava/lang/String;)[B", ref global::javax.sql.RowSet_._m127, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m128;
		byte[] java.sql.ResultSet.getBytes(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::javax.sql.RowSet_.staticClass, "getBytes", "(I)[B", ref global::javax.sql.RowSet_._m128, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m129;
		global::java.sql.Array java.sql.ResultSet.getArray(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Array>(this, global::javax.sql.RowSet_.staticClass, "getArray", "(Ljava/lang/String;)Ljava/sql/Array;", ref global::javax.sql.RowSet_._m129, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Array;
		}
		private static global::MonoJavaBridge.MethodId _m130;
		global::java.sql.Array java.sql.ResultSet.getArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Array>(this, global::javax.sql.RowSet_.staticClass, "getArray", "(I)Ljava/sql/Array;", ref global::javax.sql.RowSet_._m130, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Array;
		}
		private static global::MonoJavaBridge.MethodId _m131;
		bool java.sql.ResultSet.next()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "next", "()Z", ref global::javax.sql.RowSet_._m131);
		}
		private static global::MonoJavaBridge.MethodId _m132;
		global::java.net.URL java.sql.ResultSet.getURL(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::javax.sql.RowSet_.staticClass, "getURL", "(Ljava/lang/String;)Ljava/net/URL;", ref global::javax.sql.RowSet_._m132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m133;
		global::java.net.URL java.sql.ResultSet.getURL(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URL>(this, global::javax.sql.RowSet_.staticClass, "getURL", "(I)Ljava/net/URL;", ref global::javax.sql.RowSet_._m133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.net.URL;
		}
		private static global::MonoJavaBridge.MethodId _m134;
		void java.sql.ResultSet.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "close", "()V", ref global::javax.sql.RowSet_._m134);
		}
		private static global::MonoJavaBridge.MethodId _m135;
		int java.sql.ResultSet.getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getType", "()I", ref global::javax.sql.RowSet_._m135);
		}
		private static global::MonoJavaBridge.MethodId _m136;
		bool java.sql.ResultSet.previous()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "previous", "()Z", ref global::javax.sql.RowSet_._m136);
		}
		private static global::MonoJavaBridge.MethodId _m137;
		global::java.sql.Ref java.sql.ResultSet.getRef(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Ref>(this, global::javax.sql.RowSet_.staticClass, "getRef", "(I)Ljava/sql/Ref;", ref global::javax.sql.RowSet_._m137, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Ref;
		}
		private static global::MonoJavaBridge.MethodId _m138;
		global::java.sql.Ref java.sql.ResultSet.getRef(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Ref>(this, global::javax.sql.RowSet_.staticClass, "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;", ref global::javax.sql.RowSet_._m138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Ref;
		}
		private static global::MonoJavaBridge.MethodId _m139;
		global::java.lang.String java.sql.ResultSet.getString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::javax.sql.RowSet_._m139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m140;
		global::java.lang.String java.sql.ResultSet.getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getString", "(I)Ljava/lang/String;", ref global::javax.sql.RowSet_._m140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m141;
		bool java.sql.ResultSet.isFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "isFirst", "()Z", ref global::javax.sql.RowSet_._m141);
		}
		private static global::MonoJavaBridge.MethodId _m142;
		global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", ref global::javax.sql.RowSet_._m142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m143;
		global::java.sql.Time java.sql.ResultSet.getTime(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getTime", "(Ljava/lang/String;)Ljava/sql/Time;", ref global::javax.sql.RowSet_._m143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m144;
		global::java.sql.Time java.sql.ResultSet.getTime(int arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;", ref global::javax.sql.RowSet_._m144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m145;
		global::java.sql.Time java.sql.ResultSet.getTime(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getTime", "(I)Ljava/sql/Time;", ref global::javax.sql.RowSet_._m145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Time;
		}
		private static global::MonoJavaBridge.MethodId _m146;
		global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getDate", "(Ljava/lang/String;)Ljava/sql/Date;", ref global::javax.sql.RowSet_._m146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m147;
		global::java.sql.Date java.sql.ResultSet.getDate(java.lang.String arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", ref global::javax.sql.RowSet_._m147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m148;
		global::java.sql.Date java.sql.ResultSet.getDate(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getDate", "(I)Ljava/sql/Date;", ref global::javax.sql.RowSet_._m148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m149;
		global::java.sql.Date java.sql.ResultSet.getDate(int arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;", ref global::javax.sql.RowSet_._m149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Date;
		}
		private static global::MonoJavaBridge.MethodId _m150;
		bool java.sql.ResultSet.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "isClosed", "()Z", ref global::javax.sql.RowSet_._m150);
		}
		private static global::MonoJavaBridge.MethodId _m151;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;", ref global::javax.sql.RowSet_._m151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m152;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;", ref global::javax.sql.RowSet_._m152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m153;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(java.lang.String arg0, java.util.Calendar arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", ref global::javax.sql.RowSet_._m153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m154;
		global::java.sql.Timestamp java.sql.ResultSet.getTimestamp(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getTimestamp", "(I)Ljava/sql/Timestamp;", ref global::javax.sql.RowSet_._m154, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Timestamp;
		}
		private static global::MonoJavaBridge.MethodId _m155;
		bool java.sql.ResultSet.last()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "last", "()Z", ref global::javax.sql.RowSet_._m155);
		}
		private static global::MonoJavaBridge.MethodId _m156;
		bool java.sql.ResultSet.first()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "first", "()Z", ref global::javax.sql.RowSet_._m156);
		}
		private static global::MonoJavaBridge.MethodId _m157;
		void java.sql.ResultSet.updateBytes(java.lang.String arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBytes", "(Ljava/lang/String;[B)V", ref global::javax.sql.RowSet_._m157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m158;
		void java.sql.ResultSet.updateBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBytes", "(I[B)V", ref global::javax.sql.RowSet_._m158, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m159;
		bool java.sql.ResultSet.isLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "isLast", "()Z", ref global::javax.sql.RowSet_._m159);
		}
		private static global::MonoJavaBridge.MethodId _m160;
		bool java.sql.ResultSet.isBeforeFirst()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "isBeforeFirst", "()Z", ref global::javax.sql.RowSet_._m160);
		}
		private static global::MonoJavaBridge.MethodId _m161;
		bool java.sql.ResultSet.isAfterLast()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "isAfterLast", "()Z", ref global::javax.sql.RowSet_._m161);
		}
		private static global::MonoJavaBridge.MethodId _m162;
		global::java.sql.Blob java.sql.ResultSet.getBlob(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Blob>(this, global::javax.sql.RowSet_.staticClass, "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;", ref global::javax.sql.RowSet_._m162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Blob;
		}
		private static global::MonoJavaBridge.MethodId _m163;
		global::java.sql.Blob java.sql.ResultSet.getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Blob>(this, global::javax.sql.RowSet_.staticClass, "getBlob", "(I)Ljava/sql/Blob;", ref global::javax.sql.RowSet_._m163, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Blob;
		}
		private static global::MonoJavaBridge.MethodId _m164;
		void java.sql.ResultSet.updateDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateDate", "(ILjava/sql/Date;)V", ref global::javax.sql.RowSet_._m164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m165;
		void java.sql.ResultSet.updateDate(java.lang.String arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V", ref global::javax.sql.RowSet_._m165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m166;
		void java.sql.ResultSet.updateTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateTime", "(ILjava/sql/Time;)V", ref global::javax.sql.RowSet_._m166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m167;
		void java.sql.ResultSet.updateTime(java.lang.String arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V", ref global::javax.sql.RowSet_._m167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m168;
		void java.sql.ResultSet.deleteRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "deleteRow", "()V", ref global::javax.sql.RowSet_._m168);
		}
		private static global::MonoJavaBridge.MethodId _m169;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", ref global::javax.sql.RowSet_._m169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m170;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", ref global::javax.sql.RowSet_._m170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m171;
		void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;)V", ref global::javax.sql.RowSet_._m171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m172;
		void java.sql.ResultSet.updateBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/io/InputStream;J)V", ref global::javax.sql.RowSet_._m172, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m173;
		void java.sql.ResultSet.updateBlob(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::javax.sql.RowSet_._m173, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m174;
		void java.sql.ResultSet.updateBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBlob", "(ILjava/sql/Blob;)V", ref global::javax.sql.RowSet_._m174, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m175;
		void java.sql.ResultSet.updateDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateDouble", "(ID)V", ref global::javax.sql.RowSet_._m175, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m176;
		void java.sql.ResultSet.updateDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateDouble", "(Ljava/lang/String;D)V", ref global::javax.sql.RowSet_._m176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m177;
		void java.sql.ResultSet.updateFloat(java.lang.String arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateFloat", "(Ljava/lang/String;F)V", ref global::javax.sql.RowSet_._m177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m178;
		void java.sql.ResultSet.updateFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateFloat", "(IF)V", ref global::javax.sql.RowSet_._m178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m179;
		void java.sql.ResultSet.updateInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateInt", "(Ljava/lang/String;I)V", ref global::javax.sql.RowSet_._m179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m180;
		void java.sql.ResultSet.updateInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateInt", "(II)V", ref global::javax.sql.RowSet_._m180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m181;
		void java.sql.ResultSet.updateLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateLong", "(Ljava/lang/String;J)V", ref global::javax.sql.RowSet_._m181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m182;
		void java.sql.ResultSet.updateLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateLong", "(IJ)V", ref global::javax.sql.RowSet_._m182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m183;
		void java.sql.ResultSet.updateShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateShort", "(IS)V", ref global::javax.sql.RowSet_._m183, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m184;
		void java.sql.ResultSet.updateShort(java.lang.String arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateShort", "(Ljava/lang/String;S)V", ref global::javax.sql.RowSet_._m184, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m185;
		void java.sql.ResultSet.updateString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateString", "(ILjava/lang/String;)V", ref global::javax.sql.RowSet_._m185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m186;
		void java.sql.ResultSet.updateString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateString", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m186, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m187;
		bool java.sql.ResultSet.wasNull()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "wasNull", "()Z", ref global::javax.sql.RowSet_._m187);
		}
		private static global::MonoJavaBridge.MethodId _m188;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(II)Ljava/math/BigDecimal;", ref global::javax.sql.RowSet_._m188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m189;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(I)Ljava/math/BigDecimal;", ref global::javax.sql.RowSet_._m189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m190;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", ref global::javax.sql.RowSet_._m190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m191;
		global::java.math.BigDecimal java.sql.ResultSet.getBigDecimal(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;", ref global::javax.sql.RowSet_._m191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.math.BigDecimal;
		}
		private static global::MonoJavaBridge.MethodId _m192;
		global::java.io.InputStream java.sql.ResultSet.getAsciiStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::javax.sql.RowSet_._m192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m193;
		global::java.io.InputStream java.sql.ResultSet.getAsciiStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getAsciiStream", "(I)Ljava/io/InputStream;", ref global::javax.sql.RowSet_._m193, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m194;
		global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::javax.sql.RowSet_._m194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m195;
		global::java.io.InputStream java.sql.ResultSet.getUnicodeStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getUnicodeStream", "(I)Ljava/io/InputStream;", ref global::javax.sql.RowSet_._m195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m196;
		global::java.io.InputStream java.sql.ResultSet.getBinaryStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getBinaryStream", "(I)Ljava/io/InputStream;", ref global::javax.sql.RowSet_._m196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m197;
		global::java.io.InputStream java.sql.ResultSet.getBinaryStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;", ref global::javax.sql.RowSet_._m197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m198;
		global::java.sql.SQLWarning java.sql.ResultSet.getWarnings()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;", ref global::javax.sql.RowSet_._m198) as java.sql.SQLWarning;
		}
		private static global::MonoJavaBridge.MethodId _m199;
		void java.sql.ResultSet.clearWarnings()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "clearWarnings", "()V", ref global::javax.sql.RowSet_._m199);
		}
		private static global::MonoJavaBridge.MethodId _m200;
		global::java.lang.String java.sql.ResultSet.getCursorName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getCursorName", "()Ljava/lang/String;", ref global::javax.sql.RowSet_._m200) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m201;
		global::java.sql.ResultSetMetaData java.sql.ResultSet.getMetaData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSetMetaData>(this, global::javax.sql.RowSet_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;", ref global::javax.sql.RowSet_._m201) as java.sql.ResultSetMetaData;
		}
		private static global::MonoJavaBridge.MethodId _m202;
		int java.sql.ResultSet.findColumn(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "findColumn", "(Ljava/lang/String;)I", ref global::javax.sql.RowSet_._m202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m203;
		global::java.io.Reader java.sql.ResultSet.getCharacterStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", ref global::javax.sql.RowSet_._m203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m204;
		global::java.io.Reader java.sql.ResultSet.getCharacterStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getCharacterStream", "(I)Ljava/io/Reader;", ref global::javax.sql.RowSet_._m204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m205;
		void java.sql.ResultSet.beforeFirst()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "beforeFirst", "()V", ref global::javax.sql.RowSet_._m205);
		}
		private static global::MonoJavaBridge.MethodId _m206;
		void java.sql.ResultSet.afterLast()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "afterLast", "()V", ref global::javax.sql.RowSet_._m206);
		}
		private static global::MonoJavaBridge.MethodId _m207;
		int java.sql.ResultSet.getRow()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getRow", "()I", ref global::javax.sql.RowSet_._m207);
		}
		private static global::MonoJavaBridge.MethodId _m208;
		bool java.sql.ResultSet.absolute(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "absolute", "(I)Z", ref global::javax.sql.RowSet_._m208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m209;
		bool java.sql.ResultSet.relative(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "relative", "(I)Z", ref global::javax.sql.RowSet_._m209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m210;
		void java.sql.ResultSet.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setFetchDirection", "(I)V", ref global::javax.sql.RowSet_._m210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m211;
		int java.sql.ResultSet.getFetchDirection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getFetchDirection", "()I", ref global::javax.sql.RowSet_._m211);
		}
		private static global::MonoJavaBridge.MethodId _m212;
		void java.sql.ResultSet.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "setFetchSize", "(I)V", ref global::javax.sql.RowSet_._m212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m213;
		int java.sql.ResultSet.getFetchSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getFetchSize", "()I", ref global::javax.sql.RowSet_._m213);
		}
		private static global::MonoJavaBridge.MethodId _m214;
		int java.sql.ResultSet.getConcurrency()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getConcurrency", "()I", ref global::javax.sql.RowSet_._m214);
		}
		private static global::MonoJavaBridge.MethodId _m215;
		bool java.sql.ResultSet.rowUpdated()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "rowUpdated", "()Z", ref global::javax.sql.RowSet_._m215);
		}
		private static global::MonoJavaBridge.MethodId _m216;
		bool java.sql.ResultSet.rowInserted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "rowInserted", "()Z", ref global::javax.sql.RowSet_._m216);
		}
		private static global::MonoJavaBridge.MethodId _m217;
		bool java.sql.ResultSet.rowDeleted()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::javax.sql.RowSet_.staticClass, "rowDeleted", "()Z", ref global::javax.sql.RowSet_._m217);
		}
		private static global::MonoJavaBridge.MethodId _m218;
		void java.sql.ResultSet.updateNull(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNull", "(Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m218, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m219;
		void java.sql.ResultSet.updateNull(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNull", "(I)V", ref global::javax.sql.RowSet_._m219, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m220;
		void java.sql.ResultSet.updateBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBoolean", "(IZ)V", ref global::javax.sql.RowSet_._m220, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m221;
		void java.sql.ResultSet.updateBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBoolean", "(Ljava/lang/String;Z)V", ref global::javax.sql.RowSet_._m221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m222;
		void java.sql.ResultSet.updateByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateByte", "(IB)V", ref global::javax.sql.RowSet_._m222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m223;
		void java.sql.ResultSet.updateByte(java.lang.String arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateByte", "(Ljava/lang/String;B)V", ref global::javax.sql.RowSet_._m223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m224;
		void java.sql.ResultSet.updateBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBigDecimal", "(ILjava/math/BigDecimal;)V", ref global::javax.sql.RowSet_._m224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m225;
		void java.sql.ResultSet.updateBigDecimal(java.lang.String arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", ref global::javax.sql.RowSet_._m225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m226;
		void java.sql.ResultSet.updateTimestamp(java.lang.String arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", ref global::javax.sql.RowSet_._m226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m227;
		void java.sql.ResultSet.updateTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateTimestamp", "(ILjava/sql/Timestamp;)V", ref global::javax.sql.RowSet_._m227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m228;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::javax.sql.RowSet_._m228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m229;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", ref global::javax.sql.RowSet_._m229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m230;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;J)V", ref global::javax.sql.RowSet_._m230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m231;
		void java.sql.ResultSet.updateAsciiStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", ref global::javax.sql.RowSet_._m231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m232;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;)V", ref global::javax.sql.RowSet_._m232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m233;
		void java.sql.ResultSet.updateAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateAsciiStream", "(ILjava/io/InputStream;I)V", ref global::javax.sql.RowSet_._m233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m234;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", ref global::javax.sql.RowSet_._m234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m235;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;I)V", ref global::javax.sql.RowSet_._m235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m236;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;J)V", ref global::javax.sql.RowSet_._m236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m237;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", ref global::javax.sql.RowSet_._m237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m238;
		void java.sql.ResultSet.updateBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(ILjava/io/InputStream;)V", ref global::javax.sql.RowSet_._m238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m239;
		void java.sql.ResultSet.updateBinaryStream(java.lang.String arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", ref global::javax.sql.RowSet_._m239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m240;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", ref global::javax.sql.RowSet_._m240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m241;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;I)V", ref global::javax.sql.RowSet_._m241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m242;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;J)V", ref global::javax.sql.RowSet_._m242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m243;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::javax.sql.RowSet_._m243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m244;
		void java.sql.ResultSet.updateCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(ILjava/io/Reader;)V", ref global::javax.sql.RowSet_._m244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m245;
		void java.sql.ResultSet.updateCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::javax.sql.RowSet_._m245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m246;
		void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V", ref global::javax.sql.RowSet_._m246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m247;
		void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateObject", "(ILjava/lang/Object;)V", ref global::javax.sql.RowSet_._m247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m248;
		void java.sql.ResultSet.updateObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateObject", "(ILjava/lang/Object;I)V", ref global::javax.sql.RowSet_._m248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m249;
		void java.sql.ResultSet.updateObject(java.lang.String arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", ref global::javax.sql.RowSet_._m249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m250;
		void java.sql.ResultSet.insertRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "insertRow", "()V", ref global::javax.sql.RowSet_._m250);
		}
		private static global::MonoJavaBridge.MethodId _m251;
		void java.sql.ResultSet.updateRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateRow", "()V", ref global::javax.sql.RowSet_._m251);
		}
		private static global::MonoJavaBridge.MethodId _m252;
		void java.sql.ResultSet.refreshRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "refreshRow", "()V", ref global::javax.sql.RowSet_._m252);
		}
		private static global::MonoJavaBridge.MethodId _m253;
		void java.sql.ResultSet.cancelRowUpdates()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "cancelRowUpdates", "()V", ref global::javax.sql.RowSet_._m253);
		}
		private static global::MonoJavaBridge.MethodId _m254;
		void java.sql.ResultSet.moveToInsertRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "moveToInsertRow", "()V", ref global::javax.sql.RowSet_._m254);
		}
		private static global::MonoJavaBridge.MethodId _m255;
		void java.sql.ResultSet.moveToCurrentRow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "moveToCurrentRow", "()V", ref global::javax.sql.RowSet_._m255);
		}
		private static global::MonoJavaBridge.MethodId _m256;
		global::java.sql.Statement java.sql.ResultSet.getStatement()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Statement>(this, global::javax.sql.RowSet_.staticClass, "getStatement", "()Ljava/sql/Statement;", ref global::javax.sql.RowSet_._m256) as java.sql.Statement;
		}
		private static global::MonoJavaBridge.MethodId _m257;
		global::java.sql.Clob java.sql.ResultSet.getClob(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Clob>(this, global::javax.sql.RowSet_.staticClass, "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;", ref global::javax.sql.RowSet_._m257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Clob;
		}
		private static global::MonoJavaBridge.MethodId _m258;
		global::java.sql.Clob java.sql.ResultSet.getClob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Clob>(this, global::javax.sql.RowSet_.staticClass, "getClob", "(I)Ljava/sql/Clob;", ref global::javax.sql.RowSet_._m258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.Clob;
		}
		private static global::MonoJavaBridge.MethodId _m259;
		void java.sql.ResultSet.updateRef(java.lang.String arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V", ref global::javax.sql.RowSet_._m259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m260;
		void java.sql.ResultSet.updateRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateRef", "(ILjava/sql/Ref;)V", ref global::javax.sql.RowSet_._m260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m261;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", ref global::javax.sql.RowSet_._m261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m262;
		void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/io/Reader;)V", ref global::javax.sql.RowSet_._m262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m263;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::javax.sql.RowSet_._m263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m264;
		void java.sql.ResultSet.updateClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/io/Reader;J)V", ref global::javax.sql.RowSet_._m264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m265;
		void java.sql.ResultSet.updateClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::javax.sql.RowSet_._m265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m266;
		void java.sql.ResultSet.updateClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateClob", "(ILjava/sql/Clob;)V", ref global::javax.sql.RowSet_._m266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m267;
		void java.sql.ResultSet.updateArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateArray", "(ILjava/sql/Array;)V", ref global::javax.sql.RowSet_._m267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m268;
		void java.sql.ResultSet.updateArray(java.lang.String arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V", ref global::javax.sql.RowSet_._m268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m269;
		int java.sql.ResultSet.getHoldability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.sql.RowSet_.staticClass, "getHoldability", "()I", ref global::javax.sql.RowSet_._m269);
		}
		private static global::MonoJavaBridge.MethodId _m270;
		void java.sql.ResultSet.updateNString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNString", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::javax.sql.RowSet_._m270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m271;
		void java.sql.ResultSet.updateNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNString", "(ILjava/lang/String;)V", ref global::javax.sql.RowSet_._m271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m272;
		void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNClob", "(ILjava/io/Reader;)V", ref global::javax.sql.RowSet_._m272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m273;
		void java.sql.ResultSet.updateNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNClob", "(ILjava/io/Reader;J)V", ref global::javax.sql.RowSet_._m273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m274;
		void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::javax.sql.RowSet_._m274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m275;
		void java.sql.ResultSet.updateNClob(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::javax.sql.RowSet_._m275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m276;
		global::java.lang.String java.sql.ResultSet.getNString(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getNString", "(Ljava/lang/String;)Ljava/lang/String;", ref global::javax.sql.RowSet_._m276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m277;
		global::java.lang.String java.sql.ResultSet.getNString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.sql.RowSet_.staticClass, "getNString", "(I)Ljava/lang/String;", ref global::javax.sql.RowSet_._m277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m278;
		global::java.io.Reader java.sql.ResultSet.getNCharacterStream(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getNCharacterStream", "(I)Ljava/io/Reader;", ref global::javax.sql.RowSet_._m278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m279;
		global::java.io.Reader java.sql.ResultSet.getNCharacterStream(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::javax.sql.RowSet_.staticClass, "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", ref global::javax.sql.RowSet_._m279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.Reader;
		}
		private static global::MonoJavaBridge.MethodId _m280;
		void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;)V", ref global::javax.sql.RowSet_._m280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m281;
		void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", ref global::javax.sql.RowSet_._m281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m282;
		void java.sql.ResultSet.updateNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(ILjava/io/Reader;J)V", ref global::javax.sql.RowSet_._m282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m283;
		void java.sql.ResultSet.updateNCharacterStream(java.lang.String arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::javax.sql.RowSet_.staticClass, "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", ref global::javax.sql.RowSet_._m283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static RowSet_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.sql.RowSet_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/sql/RowSet"));
		}
	}
}
